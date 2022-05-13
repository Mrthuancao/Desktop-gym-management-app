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

        public bool logIn(string username, string pass)
        {
            string Username = "";
            DataTable dt = accountDAL.getLoginAccount(username, pass);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Username = row["username"].ToString();
                }
            }
            if (Username != "")
                return true;
            return false;
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
                accountDAL.insertAccount(matk, username, getHashMD5(pass).ToString(), manv);
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

        /*public bool updateAccount(string username, string name, string phone, string email)
        {
            try
            {
                return (accountDAL.updateAccount(username, name, phone, email));

            }
            catch (Exception)
            {
                return false;
            }
        }*/

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
    }
}
