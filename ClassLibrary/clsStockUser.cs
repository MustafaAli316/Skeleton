using System;

namespace ClassLibrary
{
    public class clsStockUser
    {

        private Int32 mUserID;
        private string mUserName;
        private string mPassword;
        private string mDepartment;


        public int UserID {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
            }
        }

        public string UserName {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }

        public string Password {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            } 
        }

        public string Department {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }


        public bool FindUser(string UserName, string Password)
        {
            //create instance of data
            clsDataConnection DB = new clsDataConnection();
            //add the parameters 
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy data from db
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                
                return true;

            }
            else
            {
                return false;   
            }

        }



    }
}