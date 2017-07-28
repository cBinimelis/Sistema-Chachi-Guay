﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing;

namespace Sistema_Chachi_Guay
{
    class SQL
    {
        String conexion = "Data Source=localhost;Initial Catalog=bd_biblioteca;User ID=sa;Password=crislyn;MultipleActiveResultSets=True";
        SqlConnection con;

        public SQL()
        {
            con = new SqlConnection(conexion);
        }

        public void conectar()
        {
            try
            {
                con.Open();
            }
            catch { }

        }
        public void desconectar()
        {
            try
            {
                con.Close();
            }
            catch { }
        }
        public SqlDataReader consulta(String sentencia)
        {
            try
            {
                conectar();
                SqlCommand comando = new SqlCommand(sentencia, con);
                return comando.ExecuteReader();
            }
            catch { return null; }
        }

        public int ejecutar(String sentencia)
        {
            try
            {
                conectar();
                SqlCommand comando = new SqlCommand(sentencia, con);
                return comando.ExecuteNonQuery();
            }
            catch { return -1; }
        }

        public Boolean verificar(String sentencia)
        {
            try
            {
                return consulta(sentencia).Read();
            }
            catch { return false; }
        }
        public void llenaGrid(DataGridView dg, String sentencia)
        {
            try
            {
                con.Close();
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(sentencia, con);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dg.DataSource = ds.Tables[0];
                con.Close();
            }
            catch { }
        }

        public void llenaImagen(PictureBox pb, String sentencia)
        {
            //try
            //{
                con.Close();
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(sentencia, con);
                DataSet dataSet = new DataSet();
                adapt.Fill(dataSet);

                if (dataSet.Tables[0].Rows.Count == 1)
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(dataSet.Tables[0].Rows[0]["Imagen"]);
                    MemoryStream ms = new MemoryStream(data);
                    pb.Image = Image.FromStream(ms);
                }
            //}
            //catch { }
        }

        public void llenaCombo(ComboBox cb, String Sentencia)
        {
            con.Close();
            con.Open();
            SqlCommand sqlCmd = new SqlCommand(Sentencia, con);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            while (sqlReader.Read())
            {
                cb.Items.Add(sqlReader["Descripcion"].ToString());
            }
        }
    }
}
