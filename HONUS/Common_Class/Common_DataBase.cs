using System;
using System.Data.OleDb;
using System.Data;

namespace HONUS.Common_Class
{
	/// <summary>
	/// Common_DataBase에 대한 요약 설명입니다.
	/// </summary>
	public class Common_DataBase
	{
		private OleDbConnection conn;
		private OleDbCommand comm;
		private OleDbDataAdapter ad;

		private string strQuery;

		public Common_DataBase()
		{
			//conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=HONUS ;Data Source = " + System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\HONUS.mdb");
			conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Jet OLEDB:Database Password=HONUS ;Data Source = " + System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\HONUS.mdb");
			//conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=HONUS ;Data Source = c:\\HONUS.mdb");
			//conn = new OleDbConnection("Provider=SQLOLEDB;server=(local);uid=sa;pwd=admin5;Trusted_Connection=true;database=TDPMS_V3");
			comm = new OleDbCommand("",conn);
			ad = new OleDbDataAdapter(comm);

			strQuery = "";
		}

		public int ExecuteNonQuery_Text()
		{
			int dTemp = 0;
			conn.Open();

			comm.CommandType = System.Data.CommandType.Text;
			comm.CommandText = strQuery;
			dTemp = comm.ExecuteNonQuery();

			conn.Close();
			return dTemp;
		}

		public int ExecuteNonQuery_Proc()
		{
			int dTemp = 0;
			conn.Open();

			comm.CommandType = System.Data.CommandType.StoredProcedure;

			dTemp = comm.ExecuteNonQuery();

			conn.Close();

			return dTemp;
		}

		public string ExecuteScalar_Text()
		{
			string dTemp = "";
			conn.Open();

			comm.CommandType = System.Data.CommandType.Text;
			comm.CommandText = strQuery;
			dTemp = comm.ExecuteScalar().ToString();

			conn.Close();

			return dTemp;
		}

		public string ExecuteScalar_Proc()
		{
			string dTemp = "";
			conn.Open();

			comm.CommandType = System.Data.CommandType.StoredProcedure;

			dTemp = comm.ExecuteScalar().ToString();

			conn.Close();

			return dTemp;
		}

		public DataSet GetDataSet_Text()
		{
			comm.CommandType = System.Data.CommandType.Text;
			comm.CommandText = strQuery;

			DataSet ds = new DataSet();
			ad.Fill(ds);

			return ds;
		}

		public DataSet GetDataSet_Proc()
		{
			comm.CommandType = System.Data.CommandType.StoredProcedure;

			DataSet ds = new DataSet();
			ad.Fill(ds);

			return ds;
		}


		#region 접근 함수
		
		public void CommandParameterAdd(string strKey,System.Data.OleDb.OleDbType Type,int Size,string strValue)
		{
			((System.Data.OleDb.OleDbParameter)comm.Parameters.Add(strKey,Type,Size)).Value = strValue;
		}

		public void CommandParameterClear()
		{
			comm.Parameters.Clear();
		}

		public void CommandParameterDeleteAt(string strParameterName)
		{
			comm.Parameters.RemoveAt(strParameterName);
		}

		public void CommandParameterDeleteAt(int dParameterIndex)
		{
			comm.Parameters.RemoveAt(dParameterIndex);
		}

		#endregion

		#region 접근자

		public string Query
		{
			get
			{
				return this.strQuery;
			}
			set
			{
				this.strQuery = value;
			}
		}

		#endregion
	}
}
