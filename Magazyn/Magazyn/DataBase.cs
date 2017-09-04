using Be.Timvw.Framework.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn
{
    class DataBase
    {
        #region Constructor
        static DataBase instance;
        public static DataBase GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new DataBase();
                return instance;
            }
        }
        private DataBase()
        {
            connection = new SQLiteConnection(string.Format("Data Source={0}", Path.Combine(Application.StartupPath, "data.db")));
            command = new SQLiteCommand(connection);


        }
        #endregion Constructor

        #region Proterties
        SQLiteConnection connection;
        SQLiteCommand command;
        SQLiteDataReader reader;
        SortableBindingList<Product> productsList = new SortableBindingList<Product>();
        SortableBindingList<Category> categoriesList = new SortableBindingList<Category>();
        SortableBindingList<Localization> localizationsList = new SortableBindingList<Localization>();
        SortableBindingList<Delivery> deliveriesList = new SortableBindingList<Delivery>();


        internal SortableBindingList<Category> CategoriesList { get => categoriesList; set => categoriesList = value; }
        internal SortableBindingList<Localization> LocalizationsList { get => localizationsList; set => localizationsList = value; }
        internal SortableBindingList<Product> ProductsList { get => productsList; set => productsList = value; }
        public SortableBindingList<Delivery> DeliveriesList { get => deliveriesList; set => deliveriesList = value; }
        #endregion Proterties

        #region DatabaseInitiation
        public void InitiateDataBase()
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = "CREATE TABLE IF NOT EXISTS products (id integer primary key autoincrement, name TEXT, code TEXT, description TEXT, quantity INTEGER, reservation INTEGER, price REAL, categoryid INTEGER REFERENCES categories (id), localizationid INTEGER REFERENCES localizations (id))";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE IF NOT EXISTS deliveries (id integer primary key autoincrement, code TEXT, name TEXT, date TEXT)";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE IF NOT EXISTS categories (id integer primary key autoincrement, category TEXT)";
                command.ExecuteNonQuery();
                command.CommandText = "SELECT COUNT(*) FROM categories";
                if (!(Convert.ToInt32(command.ExecuteScalar()) > 0))
                {
                    command.CommandText = "INSERT INTO categories VALUES (NULL, ' ')";
                    command.ExecuteNonQuery();
                }
                command.CommandText = "CREATE TABLE IF NOT EXISTS localizations (id integer primary key autoincrement, localization TEXT)";
                command.ExecuteNonQuery();
                command.CommandText = "SELECT COUNT(*) FROM localizations";
                if (!(Convert.ToInt32(command.ExecuteScalar()) > 0))
                {
                    command.CommandText = "INSERT INTO localizations VALUES (NULL, ' ')";
                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
        }


        #endregion DatabaseInitiation

        #region Categories

        public List<Category> GetCategories()
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = "SELECT * FROM categories";
                reader = command.ExecuteReader();
                categoriesList.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        categoriesList.Add(new Category(reader.GetInt32(0), reader.GetString(1)));
                    }
                }
            }
            reader.Close();
            connection.Close();
            return categoriesList.ToList();
        }



        public void UpdateCategory(string name, int id)
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = string.Format("UPDATE categories SET category = '{0}' WHERE ID = {1}", name, id);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void CreateCategory(string name)
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = "INSERT INTO categories VALUES (NULL, '" + name + "')";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void DeleteCategory(Category category)
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = "DELETE FROM categories WHERE id = " + category.Id;
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        #endregion Categories

        #region Localizations
        public List<Localization> GetLocalizations()
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = "SELECT * FROM localizations";
                reader = command.ExecuteReader();
                localizationsList.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        localizationsList.Add(new Localization(reader.GetInt32(0), reader.GetString(1)));
                    }
                }
            }
            reader.Close();
            connection.Close();
            return localizationsList.ToList();
        }

        public void UpdateLocalization(string name, int id)
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = string.Format("UPDATE localizations SET localization= '{0}' WHERE ID = {1}", name, id);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void CreateLocalization(string name)
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = "INSERT INTO localizations VALUES (NULL, '" + name + "')";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void DeleteLocalization(Localization localization)
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = "DELETE FROM localizations WHERE id = " + localization.Id;
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        #endregion Localizations

        #region Deliveries

        public List<Delivery> GetDeliveries()
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = "SELECT * FROM deliveries";
                reader = command.ExecuteReader();
                deliveriesList.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        deliveriesList.Add(new Delivery(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                    }
                }
            }
            reader.Close();
            connection.Close();
            return deliveriesList.ToList();
        }

        public SortableBindingList<ProductOnMove> GetDeliveryProducts(string deliveryCode)
        {
            SortableBindingList<ProductOnMove> delivery = new SortableBindingList<ProductOnMove>();
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = "SELECT * FROM " + deliveryCode + " LEFT JOIN products ON "+deliveryCode+
                    ".productid = products.id LEFT JOIN categories ON products.categoryid = categories.id " +
                    "LEFT JOIN localizations ON products.localizationid= localizations.id";
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        delivery.Add(new ProductOnMove(Convert.ToInt32(reader["id"]), reader["name"].ToString(), 
                            reader["code"].ToString(), reader["description"].ToString(), Convert.ToInt32(reader["quantity"]),
                            Convert.ToInt32(reader["reservation"]), Convert.ToInt32(reader["quantityOnMove"]), Convert.ToDecimal(reader["price"]), reader["category"].ToString(), 
                            reader["localization"].ToString()));
                    }
                }
            }
            reader.Close();
            connection.Close();
            return delivery;
        }



        public void UpdateDelivery(Delivery delivery)
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = string.Format("UPDATE deliveries SET name = '{0}' WHERE ID = {1}", delivery.Name, delivery.Id);
                command.ExecuteNonQuery();
                command.CommandText = string.Format("DELETE FROM {0} ", delivery.Code);
                command.ExecuteNonQuery();
                foreach (var item in delivery.ProductsList)
                {
                    command.CommandText = string.Format("INSERT INTO {0} (productid, quantityOnMove) VALUES({1}, {2}) ", delivery.Code, item.Id, item.QuantityOnMove);
                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
        }

        public void CreateDelivery(string name, string code, string date)
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = "INSERT INTO deliveries VALUES (NULL, '" + code + "', '"+name+"', '"+date+"')";
                command.ExecuteNonQuery();
                command.CommandText = "CREATE TABLE "+code+ " (productid INTEGER REFERENCES products (id), quantityOnMove INT)";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void DeleteDelivery(Delivery delivery)
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = "DELETE FROM deliveries WHERE id = " + delivery.Id;
                command.ExecuteNonQuery();
                command.CommandText = string.Format("DROP TABLE {0}" ,delivery.Code);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        #endregion Deliveries


        #region Products

        public List<Product> SearchProducts(string category, string localization, string search)
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = "SELECT * FROM products LEFT JOIN categories ON products.categoryid= categories.id " +
                    "LEFT JOIN localizations ON products.localizationid= localizations.id " +
                    "WHERE " +
                    "(NAME LIKE '%" + search + "%' OR " +
                    "code LIKE '%" + search + "%' OR " +
                    "description LIKE '%" + search + "%')";
                if (!string.IsNullOrWhiteSpace(category))
                {
                    command.CommandText += " AND category = '" + category + "'";
                }
                if (!string.IsNullOrWhiteSpace(localization))
                {
                    command.CommandText += " AND localization = '" + localization + "'";
                }
                reader = command.ExecuteReader();
                ProductsList.Clear();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ProductsList.Add(new Product(Convert.ToInt32(reader["id"]), reader["name"].ToString(), reader["code"].ToString(), reader["description"].ToString(), Convert.ToInt32(reader["quantity"]), Convert.ToInt32(reader["reservation"]), Convert.ToDecimal(reader["price"]), reader["category"].ToString(), reader["localization"].ToString()));
                    }
                }
            }
            reader.Close();
            connection.Close();
            return ProductsList?.ToList();
        }

        internal void DeleteProduct(Product product)
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = "DELETE FROM products WHERE id = @param1";
                command.Parameters.Add(new SQLiteParameter("@param1", product.Id));
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        internal void EditProduct(Product product)
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = "UPDATE products SET name = @param1, code = @param2, description = @param3, quantity = @param4, reservation = @param5, price = @param6, categoryid = @param7, localizationid = @param8 WHERE id = @param9";
                command.Parameters.Add(new SQLiteParameter("@param1", product.Name));
                command.Parameters.Add(new SQLiteParameter("@param2", product.Code));
                command.Parameters.Add(new SQLiteParameter("@param3", product.Description));
                command.Parameters.Add(new SQLiteParameter("@param4", product.Quantity));
                command.Parameters.Add(new SQLiteParameter("@param5", product.Reservation));
                command.Parameters.Add(new SQLiteParameter("@param6", product.Price));
                command.Parameters.Add(new SQLiteParameter("@param7", categoriesList.FirstOrDefault(x => x.Name == product.Category)?.Id));
                command.Parameters.Add(new SQLiteParameter("@param8", localizationsList.FirstOrDefault(x => x.Name == product.Localization)?.Id));
                command.Parameters.Add(new SQLiteParameter("@param9", product.Id));
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void AddProduct(Product product)
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command.CommandText = "INSERT INTO products VALUES(null, @param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8)";
                command.Parameters.Add(new SQLiteParameter("@param1", product.Name));
                command.Parameters.Add(new SQLiteParameter("@param2", product.Code));
                command.Parameters.Add(new SQLiteParameter("@param3", product.Description));
                command.Parameters.Add(new SQLiteParameter("@param4", product.Quantity));
                command.Parameters.Add(new SQLiteParameter("@param5", product.Reservation));
                command.Parameters.Add(new SQLiteParameter("@param6", product.Price));
                command.Parameters.Add(new SQLiteParameter("@param7", categoriesList.FirstOrDefault(x => x.Name == product.Category)?.Id));
                command.Parameters.Add(new SQLiteParameter("@param8", localizationsList.FirstOrDefault(x => x.Name == product.Localization)?.Id));
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        #endregion Products

    }

}
