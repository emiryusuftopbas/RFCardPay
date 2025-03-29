using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RFCardPay
{
    class RFCardPayDAL
    {
        SqlConnection connection;
        public RFCardPayDAL()
        {
            connection = new SqlConnection(@"Data Source=laptop-emir;Initial Catalog=RFCardPay;Integrated Security=True");
        }
        public bool AddCard(string NameSurname, string PhoneNumber, double Balance, string RfidCardNo)
        {
            connection.Open();
            SqlCommand addCard = new SqlCommand($"INSERT INTO Cards (NameSurname,PhoneNumber,Balance,CardID) VALUES ('{NameSurname}','{PhoneNumber}','{Balance}','{RfidCardNo}')", connection);
            int flag = addCard.ExecuteNonQuery();
            connection.Close();
            if (flag == 0)
                return false;
            else
                return true;
        }
        public bool UpdateCard(int RecordID , string NameSurname, string PhoneNumber, double Balance)
        {
            connection.Open();
            SqlCommand updateCard = new SqlCommand("UPDATE Cards SET NameSurname = @NameSurname , PhoneNumber = @PhoneNumber, Balance = @Balance WHERE RecordID = @RecordID", connection);
            updateCard.Parameters.AddWithValue("@NameSurname", SqlDbType.VarChar).Value = NameSurname;
            updateCard.Parameters.AddWithValue("@PhoneNumber", SqlDbType.VarChar).Value = PhoneNumber;
            updateCard.Parameters.AddWithValue("@Balance", SqlDbType.Float).Value = Balance;
            updateCard.Parameters.AddWithValue("@RecordID", SqlDbType.Int).Value = RecordID;

            int flag = updateCard.ExecuteNonQuery();
            connection.Close();
            if (flag == 0)
                return false;
            else
                return true;
        }
        public bool DeleteCard(int RecordId)
        {
            connection.Open();
            SqlCommand deleteCard = new SqlCommand("DELETE FROM Cards WHERE RecordID = @RecordId", connection);
            deleteCard.Parameters.AddWithValue("@RecordId", SqlDbType.Int).Value = RecordId;
           
            int flag = deleteCard.ExecuteNonQuery();
            connection.Close();
            if (flag == 0)
                return false;
            else
                return true;
        }

        public DataTable GetCards()
        {
            connection.Open();
            SqlCommand getCards = new SqlCommand($"SELECT * FROM Cards", connection);
            DataTable dt = new DataTable();
            SqlDataReader sdr = getCards.ExecuteReader();
            dt.Load(sdr);
            connection.Close();
            return dt;
        }
        public bool AddProduct(string ProductName , double ProductPrice )
        {
            connection.Open();
            SqlCommand addProduct = new SqlCommand($"INSERT INTO Products (Name,Price) VALUES ('{ProductName}','{ProductPrice}')", connection);
            int flag = addProduct.ExecuteNonQuery();
            connection.Close();
            if (flag == 0)
                return false;
            else
                return true;
        }
        public DataTable GetProducts()
        {
            connection.Open();
            SqlCommand urunleriGetir = new SqlCommand($"SELECT * FROM Products ORDER BY Id ", connection);
            DataTable dt = new DataTable();
            SqlDataReader sdr = urunleriGetir.ExecuteReader();
            dt.Load(sdr);
            connection.Close();
            return dt;
        }
        public string ProductsJson()
        {
            connection.Open();
            SqlCommand getProducts = new SqlCommand($"SELECT * FROM Products ORDER BY Id", connection);
            DataTable dt = new DataTable();
            SqlDataReader sdr = getProducts.ExecuteReader();
            dt.Load(sdr);
            connection.Close();

            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(dt); 
            JSONString = "{\"products\":" + JSONString + "}";
            return JSONString;
        }
        public bool UpdateProduct(int ProductId, string ProductName, double ProductPrice)
        {
            connection.Open();

            SqlCommand updateProduct = new SqlCommand("UPDATE Products SET Name = @ProductName, Price = @ProductPrice WHERE Id = @id ", connection);
            updateProduct.Parameters.AddWithValue("@ProductName", SqlDbType.VarChar).Value = ProductName;
            updateProduct.Parameters.AddWithValue("@ProductPrice", SqlDbType.Float).Value = ProductPrice;
            updateProduct.Parameters.AddWithValue("@id", SqlDbType.Int).Value = ProductId;

            int flag = updateProduct.ExecuteNonQuery();
            connection.Close();
            if (flag == 0)
                return false;
            else
                return true;
        }
        public bool DeleteProduct(int ProductId)
        {
            connection.Open();
            SqlCommand deleteProduct = new SqlCommand("DELETE FROM Products WHERE Id = @id ", connection);
            deleteProduct.Parameters.AddWithValue("@id", SqlDbType.Int).Value = ProductId;
            int flag = deleteProduct.ExecuteNonQuery();
            connection.Close();
            if (flag == 0)
                return false;
            else
                return true;
        }
        public bool IsEligibleForPayment(Payment payment)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM Cards WHERE (Balance-@Amount) >= 0 AND CardID = @CardID", connection);
            cmd.Parameters.AddWithValue("@CardID", SqlDbType.VarChar).Value = payment.rfid;
            cmd.Parameters.AddWithValue("@Amount", SqlDbType.VarChar).Value = payment.price;

            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            if (count > 0)
            {
                return true;
            } else
            {
                return false;
            }

        }

        public bool BuyProduct(Payment payment)
        {
            connection.Open();
            SqlCommand buyProduct = new SqlCommand($"INSERT INTO Operations (CardID,Type,Amount,ProductID) VALUES (@CardID,@Type,@Amount,@ProductId)", connection);
            buyProduct.Parameters.AddWithValue("@CardId", SqlDbType.VarChar).Value = payment.rfid;
            buyProduct.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = "purchase";
            buyProduct.Parameters.AddWithValue("@Amount", SqlDbType.Float).Value = payment.price;
            buyProduct.Parameters.AddWithValue("@ProductId", SqlDbType.Int).Value = payment.id;

            int flag = buyProduct.ExecuteNonQuery();
            connection.Close();
            if (flag == 0)
                return false;
            else
                return true;
        }
        public DataTable GetOperations()
        {
            connection.Open();
            SqlCommand getOperations = new SqlCommand("SELECT OperationID, CardID, Type, Amount, OperationTime FROM Operations ORDER BY OperationID", connection);
            DataTable dt = new DataTable();
            SqlDataReader sdr = getOperations.ExecuteReader();
            dt.Load(sdr);
            connection.Close();
            return dt;
        }

        public DataTable GetAddFundsOperations()
        {
            connection.Open();
            SqlCommand getOperations = new SqlCommand("SELECT OperationID, CardID, Amount FROM Operations WHERE Type = @type ORDER BY OperationID", connection);
            getOperations.Parameters.AddWithValue("@type", SqlDbType.VarChar).Value = "add-funds";
            DataTable dt = new DataTable();
            SqlDataReader sdr = getOperations.ExecuteReader();
            dt.Load(sdr);
            connection.Close();
            return dt;
        }

        public bool IsCardRegistered(string RfidNo)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Cards WHERE CardID = @CardID", connection);
            cmd.Parameters.AddWithValue("@CardID", SqlDbType.VarChar).Value = RfidNo;

            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddFunds(string RfidCardNumber,double Amount)
        {
            connection.Open();
            SqlCommand addFund = new SqlCommand("INSERT INTO Operations (CardID,Type,Amount) VALUES (@CardID,@Type,@Amount)", connection);
            addFund.Parameters.AddWithValue("@CardID", SqlDbType.VarChar).Value = RfidCardNumber;
            addFund.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = "add-funds";
            addFund.Parameters.AddWithValue("@Amount", SqlDbType.Float).Value = Amount;

            int flag = addFund.ExecuteNonQuery();
            connection.Close();
            if (flag == 0)
                return false;
            else
                return true;
        }
        public DataTable GetCard(string RfidCardNumber)
        {
            connection.Open();
            SqlCommand getCard = new SqlCommand($"SELECT * FROM Cards WHERE CardID = @CardID", connection);
            getCard.Parameters.AddWithValue("@CardID", SqlDbType.VarChar).Value = RfidCardNumber;
            DataTable dt = new DataTable();
            SqlDataReader sdr = getCard.ExecuteReader(CommandBehavior.SingleRow);
            dt.Load(sdr);
            connection.Close();
            return dt;
        }
        public DataTable GetCardBalanceTransactions(string RfidNo)
        {
            connection.Open();
            SqlCommand getOperations = new SqlCommand("SELECT OperationID, CardID, Amount , OperationTime FROM Operations WHERE CardID = @CardID AND Type = @Type ORDER BY OperationID", connection);
            getOperations.Parameters.AddWithValue("@CardID", SqlDbType.VarChar).Value = RfidNo;
            getOperations.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = "add-funds";
            DataTable dt = new DataTable();
            SqlDataReader sdr = getOperations.ExecuteReader();
            dt.Load(sdr);
            connection.Close();
            return dt;
        }

        public DataTable GetCardOperations(string RfidCardNumber, string OperationType , bool IsDateSelected = false, string StartDate = "",string EndDate = "")
        {
            connection.Open();
            SqlCommand getOperations;
            
            if(!IsDateSelected)
            {

                if (OperationType.Length == 0)
                {
                    getOperations = new SqlCommand("SELECT OperationID, CardID, Type, Amount, OperationTime FROM Operations WHERE CardID = @CardID ORDER BY OperationID", connection);
                    getOperations.Parameters.AddWithValue("@CardID", SqlDbType.VarChar).Value = RfidCardNumber;
                }
                else if (OperationType == "add-funds")
                {
                    getOperations = new SqlCommand("SELECT OperationID, CardID, Type, Amount, OperationTime FROM Operations WHERE CardID = @CardID AND Type = @Type ORDER BY OperationID", connection);
                    getOperations.Parameters.AddWithValue("@CardID", SqlDbType.VarChar).Value = RfidCardNumber;
                    getOperations.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = OperationType;
                }
                else
                {
                    getOperations = new SqlCommand("SELECT OperationID, CardID, Type, Products.Name, Amount, OperationTime FROM Operations LEFT JOIN Products ON  Operations.ProductID = Products.Id WHERE CardID = @CardID AND Type = @Type  ORDER BY OperationID", connection);
                    getOperations.Parameters.AddWithValue("@CardID", SqlDbType.VarChar).Value = RfidCardNumber;
                    getOperations.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = OperationType;
                }
            }
            else
            {
                if (OperationType.Length == 0)
                {
                    getOperations = new SqlCommand("SELECT OperationID, CardID, Type, Amount, OperationTime FROM Operations WHERE CardID = @CardID AND OperationTime BETWEEN @StartDate AND @EndDate ORDER BY OperationID", connection);
                    getOperations.Parameters.AddWithValue("@CardID", SqlDbType.VarChar).Value = RfidCardNumber;
                    getOperations.Parameters.AddWithValue("@StartDate", SqlDbType.VarChar).Value = StartDate;
                    getOperations.Parameters.AddWithValue("@EndDate", SqlDbType.VarChar).Value = EndDate;

                }
                else if (OperationType == "add-funds")
                {
                    getOperations = new SqlCommand("SELECT OperationID, CardID, Type, Amount, OperationTime FROM Operations WHERE CardID = @CardID AND Type = @Type AND OperationTime BETWEEN @StartDate AND @EndDate ORDER BY OperationID", connection);
                    getOperations.Parameters.AddWithValue("@CardID", SqlDbType.VarChar).Value = RfidCardNumber;
                    getOperations.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = OperationType;
                    getOperations.Parameters.AddWithValue("@StartDate", SqlDbType.VarChar).Value = StartDate;
                    getOperations.Parameters.AddWithValue("@EndDate", SqlDbType.VarChar).Value = EndDate;
                }
                else
                {
                    getOperations = new SqlCommand("SELECT OperationID, CardID, Type, Products.Name, Amount, OperationTime FROM Operations LEFT JOIN Products ON Operations.ProductID = Products.Id WHERE CardID = @CardID AND Type = @Type AND OperationTime BETWEEN @StartDate AND @EndDate  ORDER BY OperationID", connection);
                    getOperations.Parameters.AddWithValue("@CardID", SqlDbType.VarChar).Value = RfidCardNumber;
                    getOperations.Parameters.AddWithValue("@Type", SqlDbType.VarChar).Value = OperationType;
                    getOperations.Parameters.AddWithValue("@StartDate", SqlDbType.VarChar).Value = StartDate;
                    getOperations.Parameters.AddWithValue("@EndDate", SqlDbType.VarChar).Value = EndDate;
                }

            }

            DataTable dt = new DataTable();
            SqlDataReader sdr = getOperations.ExecuteReader();
            dt.Load(sdr);
            connection.Close();
            return dt;
        }

        public bool CleanTables()
        {
            connection.Open();
            SqlCommand cleanTables = new SqlCommand("SP_CleanTables", connection);

            int flag = cleanTables.ExecuteNonQuery();
            connection.Close();
            if (flag == 0)
                return false;
            else
                return true;
        }
    }
}
