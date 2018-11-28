using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*addition namespace needed.*/
//use for messagebox in this case.
using System.Windows.Forms;
//use for sql commands and functions.
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace JustRipeProjectOfficial
{
    class DBConnect
    {

        /*===============================================================[Database Connection Setup]===============================================================================================*/

        //setup logged in info.
        private int userID;

        private string connStr;
        SqlConnection connToDB;
        private SqlDataAdapter dataAdap;
        private SqlDataReader dataRead;
        SqlCommand comm;

        //Initialize (Probably)
        public DBConnect(/*string connStr*/)
        {
            Initialize();
        }

        public void Initialize() {

            string mdfPath = Path.Combine(Application.StartupPath, "DBJustRipe.mdf");

            connStr = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + mdfPath + ";Integrated Security=True;Connect Timeout=30");

        }

        //once MYSQL Connected. I believe this will actually try to connect to the database server.
        public void OpenConn()
        {

            connToDB = new SqlConnection(connStr);

            connToDB.Open();

        }

        //this will close the connection to the database server once the program closed.

        public void CloseConn() {

            connToDB.Close();

        }


        /*===============================================================[LogIn/Register Functions]===============================================================================================*/
        //[TEST SUCCESS] it used to check if username existed or not.

        public bool unCheckExist(string un)
        {

            Initialize();
            //connection query for SQL.
            OpenConn();

            string dataUN = "";

            string query = "SELECT username FROM users WHERE username = '" + un + "'";

            comm = new SqlCommand(query, connToDB);
            dataRead = comm.ExecuteReader();

            using (dataRead) {

                while (dataRead.Read()) {

                    dataUN = dataRead["username"].ToString();

                }

            }

            if (dataUN == un)
            {


                return true;

            }
            else
            {

                return false;

            }



        }



        //[TEST SUCCESS] it used to check if username, password correct or not.
        public bool loginCheck(string un, string pw)
        {

            Initialize();
            //connection query for SQL.
            OpenConn();

            string dataUN = "";
            string datapw = "";

            string query = "SELECT users_ID, username, Password FROM users WHERE username = '" + un + "'";

            comm = new SqlCommand(query, connToDB);
            dataRead = comm.ExecuteReader();

            using (dataRead)
            {

                while (dataRead.Read())
                {
                    userID = Convert.ToInt32(dataRead["users_ID"]);
                    dataUN = dataRead["username"].ToString();
                    datapw = dataRead["Password"].ToString();

                }

            }

            if (datapw == pw)
            {

                //saving user Id to the DBConnect.cs until next login
                return true;

            }
            else
            {

                return false;

            }

        }

        //temp storage List.

        public DataTable tempUserInfo;

        //use to import ONLY.
        public void userInfoImport()
        {

            tempUserInfo = new DataTable();

            string query = "SELECT users.*, ranktype.* FROM users INNER JOIN ranktype ON users.rankID = ranktype.rank_ID WHERE users_ID = '" + userID + "';";

            tempUserInfo = new DataTable();
            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);

            using (dataAdap)
            {

                dataAdap.Fill(tempUserInfo);

            }

        }
        //export ONLY
        public void userInfoExport(int userID)
        {

            tempUserInfo = new DataTable();

            Initialize();
            
            OpenConn();

            string query = "SELECT users.*, ranktype.* FROM users INNER JOIN ranktype ON users.rankID = ranktype.rank_ID WHERE users_ID = " + userID + "";

            tempUserInfo = new DataTable();
            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);

            using (dataAdap)
            {

                dataAdap.Fill(tempUserInfo);

            }

        }

        public void userCreate(string fn, string ln, DateTime dob, string g, string ad1, string ad2, string no, string un, string pw)
        {
            Initialize();
            //connection query for SQL.
            OpenConn();
            string query = "INSERT INTO Users (firstname,lastname,username,Password,ContactNum,rankID,userStatusID,DateOfBirth,Gender) VALUES(@firstname, @lastname,@username,@Password,@ContactNum,@rankID,@userStatusID,@DateOfBirth,@Gender)";

            comm = new SqlCommand(query, connToDB);

            comm.Parameters.AddWithValue("@firstname", fn);
            comm.Parameters.AddWithValue("@lastname", ln);
            comm.Parameters.AddWithValue("@username", un);
            comm.Parameters.AddWithValue("@Password", pw);
            comm.Parameters.AddWithValue("@ContactNum", no);
            comm.Parameters.AddWithValue("@rankID", 1);
            comm.Parameters.AddWithValue("userStatusID", 1);
            comm.Parameters.AddWithValue("@DateOfBirth", dob);
            comm.Parameters.AddWithValue("@Gender", g);

            comm.ExecuteNonQuery();
            dataAdap = new SqlDataAdapter(query, connToDB);
            CloseConn();
            MessageBox.Show("User Created.");


        }

        private DataTable datatable = new DataTable();

        public void passwordUpdate(string un, string pw, string newPW) {

            Initialize();
            OpenConn();

            string query = "UPDATE [Users] " +
            "SET [Password] = @NewPassword " +
            "WHERE [Users].[username] = @username";
            comm = new SqlCommand(query, connToDB);

            comm.Parameters.Add("@NewPassword", SqlDbType.VarChar).Value = newPW;
            comm.Parameters.Add("@username", SqlDbType.VarChar).Value = un;
            comm.ExecuteNonQuery();
            CloseConn();
        }


        /*===============================================================[Other Data Import/Output Functions]===============================================================================================*/

        /*=============================[Crops]=================================*/
        //functions for getting crops data
        public DataTable cropsList;
        public void getCropsData() {

            cropsList = new DataTable();

            Initialize();
            //connection query for SQL for the types of crops.
            OpenConn();
            string query = "SELECT crops_ID, cropsType FROM Crops";

            cropsList = new DataTable();
            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);

            using (dataAdap) {

                dataAdap.Fill(cropsList);

            }

        }

        public void updateCrop(int cropID, string name, int quantity, int mini, int max, int ferID, int sMID, int hMID, int sID, int vID, int sTID) {

            Initialize();
            OpenConn();

            string query = "UPDATE Crops " +
            "SET cropsType = @cropsType, " +
            "Quantity = @quantity, " +
            "miniTemp = @mini, " +
            "maxTemp = @max, " +
            "fertilizer_ID = @fid, " +
            "sowingM_ID = @sMID, " +
            "harvestM_ID = @hMID, " +
            "vehicles_ID = @vID, " +
            "specialT_ID = @sTID " +
            "WHERE cropsID = " + cropID;
            comm = new SqlCommand(query, connToDB);

            comm.Parameters.AddWithValue("@cropsType", name);
            comm.Parameters.AddWithValue("@quantity", quantity);
            comm.Parameters.AddWithValue("@mini", mini);
            comm.Parameters.AddWithValue("@max", max);
            comm.Parameters.AddWithValue("@fid", ferID);
            comm.Parameters.AddWithValue("@sMID", sMID);
            comm.Parameters.AddWithValue("@hMID", hMID);
            comm.Parameters.AddWithValue("@vID", vID);
            comm.Parameters.AddWithValue("@sTID", sTID);
            comm.ExecuteNonQuery();
            CloseConn();

        }

        public void createCrop(string name, int quantity, int mini, int max, int ferID, int sMID, int hMID, /*int sID, */int vID, int sTID) {

            Initialize();
            OpenConn();

            string query = "INSERT INTO Crops (cropsType, Quantity, miniTemp, maxTemp, fertilizer_ID, sowingM_ID, harvestM_ID, storage_ID, "/*+"vehicles_ID, "*/+"specialT_ID) " +
                "VALUES (@cropsType, @Quantity, @miniTemp, @maxTemp, @fertilizer_ID, @sowingM_ID, @harvestM_ID, "+/*"@storage_ID, "+*/"@vehicles_ID, @specialT_ID)";

            comm = new SqlCommand(query, connToDB);

            comm.Parameters.AddWithValue("@cropsType", name);
            comm.Parameters.AddWithValue("@Quantity", quantity);
            comm.Parameters.AddWithValue("@miniTemp", mini);
            comm.Parameters.AddWithValue("@maxTemp", max);
            comm.Parameters.AddWithValue("@fertilizer_ID", ferID);
            comm.Parameters.AddWithValue("@sowingM_ID", sMID);
            comm.Parameters.AddWithValue("@harvestM_ID", hMID);
            //comm.Parameters.AddWithValue("@storage_ID", sID);
            comm.Parameters.AddWithValue("@vehicles_ID", vID);
            comm.Parameters.AddWithValue("@specialT_ID", sTID);

            comm.ExecuteNonQuery();

            CloseConn();
            MessageBox.Show("Crops Created.");

        }

        // getting detials for the selected crop.
        public DataTable cropsDetail;
        public void getCropsDetails(int crops_ID) {

            Initialize();
            //connection query for displaying Crops info.
            //if any errors happened check the query.
            OpenConn();

            cropsDetail = new DataTable();

            string query = "SELECT Crops.crops_ID, Crops.Quantity, Crops.cropsType, Crops.PeriodNeeded, Crops.miniTemp, Crops.MaxTemp, " +
                "fertilizers.fertilizerType,  sowingMethods.sowingType, sowingMethods.TimeNeeded, " +
                "HarvestMethod.harvestType, harvestMethod.TimeNeeded, " +
                "Vehicles.plateNum, vehicleType.vehicleType, fuelType.fuelType, " +
                "specialTreatment.specialType, specialTreatment.Description FROM Crops " +
                "INNER JOIN fertilizers ON Crops.fertilizer_ID = fertilizers.fertilizer_ID " +
                "INNER JOIN sowingMethods ON Crops.sowingM_ID = sowingMethods.sowingM_ID " +
                "INNER JOIN HarvestMethod ON Crops.HarvestM_ID = HarvestMethod.harvestM_ID " +
                "INNER JOIN Vehicles ON Crops.vehicles_ID = Vehicles.vehicles_ID " +
                "INNER JOIN vehicleType ON Vehicles.vehicleTypeID = vehicleType.vehiclesT_ID " +
                "INNER JOIN fuelType ON Vehicles.fuelTypeID = fuelType.fuel_ID " +
                "INNER JOIN specialTreatment ON Crops.specialT_ID = specialTreatment.specialT_ID " +
                "WHERE crops_ID =" +
                " '" + crops_ID + "';";

            cropsDetail = new DataTable();
            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);

            using (dataAdap)
            {

                dataAdap.Fill(cropsDetail);

            }

        }
        /*=============================[Vehicles]=================================*/
        public DataTable vehicleTypeList;
        public void getVehicleTypeData()
        {

            Initialize();

            OpenConn();

            vehicleList = new DataTable();

            string query = "SELECT * FROM vehicleType " +
                "ORDER BY vehicleType ASC";

            vehicleTypeList = new DataTable();
            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);

            using (dataAdap)
            {

                dataAdap.Fill(vehicleTypeList);

            }

        }
        //functions for getting vehicles data.
        public DataTable vehicleList;
        public void getVehicleData() {

            Initialize();

            OpenConn();

            vehicleList = new DataTable();

            string query = "SELECT vehicleType.vehicleType + '/' + Vehicles.plateNum AS typePlate, Vehicles.*, vehicleType.* FROM Vehicles " +
                "INNER JOIN vehicleType ON Vehicles.vehicleTypeID = vehicleType.vehiclesT_ID " +
                "ORDER BY vehicleType.vehicleType, Vehicles.plateNum ASC";

            vehicleList = new DataTable();
            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);

            using (dataAdap)
            {

                dataAdap.Fill(vehicleList);

            }

        }

        //getting details for the selected vehicle.
        public DataTable vehicleDetail;
        public void getVehicleDetails(int vehicles_ID) {


            Initialize();
            //connection query for displaying Vehicle info.
            OpenConn();

            vehicleDetail = new DataTable();

            string query = "SELECT Vehicles.vehicles_ID, Vehicles.plateNum, " +
                "fuelType.fuelType, " +
                "vehicleType.vehicleType FROM Vehicles " +
                "INNER JOIN fuelType ON Vehicles.fuelTypeID = fuelType.fuel_ID " +
                "INNER JOIN vehicleType ON Vehicles.vehicleTypeID = vehicleType.vehiclesT_ID " +
                "WHERE vehicles_ID = " +
                " '" + vehicles_ID + "';";

            vehicleDetail = new DataTable();
            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);

            using (dataAdap)
            {

                dataAdap.Fill(vehicleDetail);

            }

        }

        public void createVehicle(int name, string plateNumber, int fuelType)
        {
            Initialize();
            OpenConn();

            string query = "INSERT INTO Vehicles (vehicleTypeID, plateNum, fuelTypeID, vehicleStatusID) " +
                "VALUES(@vehicleTypeID, @plateNum, @fuelTypeID, @vehicleStatusID)";

            comm = new SqlCommand(query, connToDB);

            comm.Parameters.AddWithValue("@vehicleTypeID", name);
            comm.Parameters.AddWithValue("@plateNum", plateNumber);
            comm.Parameters.AddWithValue("@fuelTypeID", fuelType);
            comm.Parameters.AddWithValue("@vehicleStatusID", 1);
            comm.ExecuteNonQuery();

        }

        public DataTable vehicleTypeFilterList;
        public void vehicleTypeFilter(int typeid) {

            Initialize();
            OpenConn();
            vehicleTypeFilterList = new DataTable();
            //output the selected vehicletyped which isnt in the status "IN USE"
            string query = "SELECT Vehicles.*, fuelType.* FROM Vehicles " +
                "INNER JOIN fuelType ON Vehicles.fuelTypeID = fuelType.fuel_ID " +
                "WHERE vehicleTypeID = " + typeid + " AND vehicleStatusID = 1 ORDER BY plateNum ASC";

            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);

            using (dataAdap)
            {

                dataAdap.Fill(vehicleTypeFilterList);

            }

            CloseConn();

        }

        /*=============================[fertilizers]=================================*/

        //functions for getting fertilizers data.
        public DataTable fertilizersList;
        public void getfertilizerData()
        {

            Initialize();
            //connection query for SQL for the types of fertilizers.
            OpenConn();

            fertilizersList = new DataTable();

            string query = "SELECT fertilizer_ID, fertilizerType FROM fertilizers";

            fertilizersList = new DataTable();
            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);

            using (dataAdap)
            {

                dataAdap.Fill(fertilizersList);

            }

        }

        public void createfertilizer(string type, int quantity) {

            Initialize();
            OpenConn();

            string query = "INSERT INTO fertilizers (fertilizerType)" +
                "VALUES (@fertilizerType)";

            comm = new SqlCommand(query, connToDB);
                       
            comm.Parameters.AddWithValue("@fertilizerType", type);
            comm.ExecuteNonQuery();



            query = "INSERT INTO FertiliserQuantity (quantity)" +
                "VALUES (@quantity)";

            comm = new SqlCommand(query, connToDB);
                       
            comm.Parameters.AddWithValue("@quantity", quantity);
            comm.ExecuteNonQuery();
            
            CloseConn();
            MessageBox.Show("Fertiliser Created.");

        }

        //getting the details for the selected fertilizer.
        public DataTable fertilizerDetail;
        public void getfertilizerDetails(int id) {

            Initialize();
            OpenConn();

            fertilizerDetail = new DataTable();

            string query;
            query = "SELECT fertilizers.*, " +
                "FertiliserQuantity.* " +
                "FROM FertiliserQuantity " +
                "INNER JOIN fertilizers ON FertiliserQuantity.fertilizer_ID = fertilizers.fertilizer_ID " +
                "WHERE FertiliserRequired_ID = " + id;

            fertilizerDetail = new DataTable();
            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);

            using (dataAdap)
            {

                dataAdap.Fill(fertilizerDetail);

            }


            CloseConn();

        }

        /*=============================[Fuel]=================================*/

        public DataTable fuelTypeList;
        public void getFuelTypeData() {

            Initialize();
            OpenConn();

            fuelTypeList = new DataTable();

            string query = "SELECT fuel_ID, fuelType FROM fuelType";

            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);

            using (dataAdap)
            {

                dataAdap.Fill(fuelTypeList);

            }


            CloseConn();

        }

        /*===============================================================[Labourer Management / Work Schedule / Timetable Functions]===============================================================================================*/

        //for the list on the left hand side of the Labourer Management
        public DataTable labourerList;
        public void getLabourersList() {

            Initialize();
            OpenConn();

            /*we need a new table call [AssignedList] with assigned_ID, crops_ID and users_ID*/
            string query = "SELECT firstname + ' ' + lastname AS fullname, * FROM users";

            labourerList = new DataTable();
            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);

            using (dataAdap)
            {

                dataAdap.Fill(labourerList);

            }


            CloseConn();

        }

        //temp storage List.
        public DataTable labourerInfo;

        //get the single data selected from the labourer list
        public void getLabourerData(int id) {

            Initialize();
            OpenConn();

            string query;
            query = "SELECT users.*, ranktype.* FROM users" +
                " INNER JOIN ranktype ON users.rankID = ranktype.rank_ID" +
                " WHERE users_ID = " + id;

            labourerInfo = new DataTable();
            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);

            using (dataAdap)
            {

                dataAdap.Fill(labourerInfo);

            }


            CloseConn();

        }
        //get the harvesttimetable for the specific user
        public void getHarvestTimeTable() { }

        public DataTable scheduleInfo;
        public void getWorkSchedule() {

            Initialize();
            //connection query for SQL.
            OpenConn();

            string query = "SELECT crops.*, workschedule.* FROM crops INNER JOIN workschedule ON crops.crops_ID = workschedule.crops_ID WHERE crops_ID!=''";

            scheduleInfo = new DataTable();
            comm = new SqlCommand(query, connToDB);
            dataAdap = new SqlDataAdapter(comm);

            using (dataAdap)
            {

                dataAdap.Fill(scheduleInfo);

            }


            CloseConn();


        }



        
    }

}

