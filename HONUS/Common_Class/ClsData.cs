using System;
using System.Collections;

namespace HONUS.Common_Class
{
	/// <summary>
	/// ClsData�� ���� ��� �����Դϴ�.
	/// </summary>
	public class ClsData
	{
		private ArrayList Data; // List of double 

		public ClsData()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
			//
			Data = new ArrayList();
		}

		public void Sum(ClsData NewData)
		{
			if (Data.Count == 0)
			{
				for (int i=0;i<NewData.GetCount();i++)
				{
					Data.Add((double)0.0);
				}
			}

			for (int i=0;i<Data.Count;i++)
			{
				Data[i] = (double)Data[i] + NewData.GetData(i);
			}
		}

		public void Divide(int Count)
		{
			for (int i=0;i<Data.Count;i++)
			{
				Data[i] = (double)Data[i] / Count;
			}
		}

		public void Clear()
		{
			Data.Clear();
		}

		public void AddData(double fData)
		{
			Data.Add(fData);
		}

		public double GetData(int Index)
		{
			return double.Parse(Data[Index].ToString());
		}

		public double [] GetData()
		{
			double [] dimResult = new double[Data.Count];
			for(int i = 0 ; i < Data.Count ; i++)
			{
				dimResult[i] = double.Parse(Data[i].ToString());
			}

			return dimResult;
		}

		public string GetString()
		{
			string strResult = "";

			for(int i = 0 ; i < Data.Count ; i++)
			{
				strResult = strResult + Data[i].ToString() + ",";
			}
			if(strResult != "")
			{
				strResult = strResult.Substring(0,strResult.Length - 1);
			}

			return strResult;
		}

		public int GetCount()
		{
			return Data.Count;
		}
	}
}
