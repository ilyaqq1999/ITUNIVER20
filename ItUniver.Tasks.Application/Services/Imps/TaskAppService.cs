﻿using ItUniver.Application.Services;

namespace ItUniver.Tasks.Application.Services.Imps
{
    public class TaskAppService : ApplicationService, ITaskAppService
    {
        public void Test()//post-method
        {

        }

        public string GetTest()
        {
            return "aaaaa";
        }

        public void TestString(string str)
        {

        }

        public string GetTestString(string str)
        {
            return "aaaaa";
        }

        public void Class(Test test)
        {

        }

        public Test GetClass(Test test)
        {
            return test;
        }
    }
}