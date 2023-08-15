using System;
using System.Collections.Generic;
using System.Data;

namespace linqdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //crud
            //create or insert, retrieve, update, delete
        }
    }

    public class MyLearnings
    {
        public int Id { get; set; }
        public string LearningName { get; set; }

        public string CreatedBy { get; set; }
    }

    public class Repo
    {
        public void Create()
        {

        }
        public void Get()
        {
            List<MyLearnings> myLearnings = new List<MyLearnings>();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
        }

        public void Get( int id)
        {
            List<MyLearnings> myLearnings = new List<MyLearnings>();
           
        }
        public void Update()
        {

        }

        public void Delete()
        {

        }

    }
}
