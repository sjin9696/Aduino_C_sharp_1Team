using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace MESProject
{
    class DataSources   // 김완수
    {
        //싱글턴 1.클래스 타입 전역변수로 선언
        //한번 선언 되면
        //static 으로 어디서든 접근가능  
        static DataSources msInst;
        static string
            strconn = "Data Source=192.168.0.19;Initial Catalog=SANGSAN;User ID=sa;Password=1234";// DB 연동주소

        SqlConnection conn;
        SqlCommand cmd;

        public static DataSources GetInstance()//싱글턴 2. 자신 클래스 타입의 메소드 
        {//클래스 객체가 생성되지 않았다면 객체생성
            if (msInst == null)
            {
                msInst = new DataSources();
            }
            return msInst;
        }
        public DataSources()//생성자 생성
        {/*
         클래스가 호출되면 생성자가생성
         생성자가 생성되면 DB에 접속하게된다.
         */
            conn = new SqlConnection(strconn);
            cmd = new SqlCommand();
        }
        //~DBConnection()//소멸자 생성 
        //{//프로그램 종료시 소멸자 발생
        // //DB연결 해제
        //    dbClose();
        //}
        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("mssql 접속!!");
            }
            catch (SqlException e)
            {
                Console.WriteLine($"접속 에러{e.Message}");
            }
        }//DB접속
        public void dbClose()
        {
            //접속해제에러는 반드시 추가해주자!
            try
            {
                conn.Close();
                Console.WriteLine("mssql 접속 해제!!");
            }
            catch (SqlException e)
            {
                Console.WriteLine("접속 해제 에러: " + e.Message);
            }
        }//DB접속해제

    }
}
