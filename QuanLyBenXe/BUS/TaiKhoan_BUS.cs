﻿using System.Text;
using DTO;
using DAO;
using System.Security.Cryptography;
using System.Data.SqlClient;
namespace BUS
{
   public class TaiKhoan_BUS
    {
        public static TaiKhoan_DTO LayTaiKhoan(string ten, string matkhau)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = TaiKhoan_BUS.GetMd5Hash(md5Hash, matkhau);
            return AccountDAO.LayTaiKhoan(ten, matkhauMH);
        }
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();

        }
    }
}
