using System;
using System.IO;
class CSVReader{
	
	public static void Main(string[] args){
		string filepath="C:\\a.csv";//Give File Path To Read 
		StreamReader streamreader=new StreamReader(filepath);
		string data=streamreader.ReadToEnd();//Use ReadToEnd Read Total Data 
		string[] csvdata=data.Split(',');//Slpit Data 
		foreach(string readdata in csvdata){
			
			Console.Write(readdata.ToString());//To Print Data
			Console.Write(" ");
		}
	}
	
}
