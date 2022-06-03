using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Security.Cryptography;

namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO accountDAL = new TaiKhoanDAO();
        public List<TAIKHOAN> GetAccountList()
        {
            List<TAIKHOAN> listAccount = new List<TAIKHOAN>();
            DataTable dt = accountDAL.getAllAccounts();
            foreach (DataRow row in dt.Rows)
            {
                TAIKHOAN account = new TAIKHOAN(row);
                listAccount.Add(account);
            }
            return listAccount;
        }

        public int logIn(string username, string pass)
        {
            string Username = "";
            String Type = "0";
            DataTable dt = accountDAL.getLoginAccount(username, pass);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Username = row["username"].ToString();
                    Type =  row["Type"].ToString();
                }
            }
            if (Username != "" & Type == "1")
                return 1;
            else if (Username != "" & Type == "0")
                return 2;
            else
                return 0;
        }

        public TAIKHOAN getAccountByUsername(string username)
        {
            TAIKHOAN account = accountDAL.getAccountByUsername(username);
            return account;
        }

        public bool updatePassword(string username, string new_password)
        {
            try
            {
                accountDAL.updatePassword(username, getHashMD5(new_password).ToString());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool insertAccount(string matk, string username, string pass, string manv)
        {
            try
            {
                accountDAL.insertAccount(matk, username, pass, manv);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool deleteAccount(string username)
        {
            try
            {
                if (accountDAL.deleteAccount(username))

                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updateAccount(string matk, string username, string pass)
        {
            try
            {
                return (accountDAL.updateAccount(matk, username, pass));

            }
            catch (Exception)
            {
                return false;
            }
        }

        public string getPasswordByUsername(string username)
        {
            try
            {
                return accountDAL.getPasswordByUsername(username);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public StringBuilder getHashMD5(string pass)
        {
            MD5 hash = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
            byte[] outputBytes = hash.ComputeHash(inputBytes);
            StringBuilder hash_str = new StringBuilder();
            for (int i = 0; i < outputBytes.Length; i++)
            {
                hash_str.Append(outputBytes[i].ToString("x2"));
            }
            return hash_str;
        }
        public DataTable GetAccountPT()
        {
            return accountDAL.GetAccountPT();
        }
        public bool DeleteAccount(string matk)
        {
            return accountDAL.deleteAccount(matk);
        }
    }
}
