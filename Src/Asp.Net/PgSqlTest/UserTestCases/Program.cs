﻿using System;

namespace OrmTest
{
    public class Cases
    {
        public static void Init()
        {
            //Demo
            Demo0_SqlSugarClient.Init();
            DemoO_Fastest.Init();
            Demo1_Queryable.Init();
            Demo2_Updateable.Init();
            Demo3_Insertable.Init();
            DemoN_SplitTable.Init();
            Demo4_Deleteable.Init();
            Demo5_SqlQueryable.Init();
            Demo6_Queue.Init();
            Demo7_Ado.Init();
            Demo8_Saveable.Init();
            Demo9_EntityMain.Init();
            DemoA_DbMain.Init();
            DemoB_Aop.Init();
            DemoC_GobalFilter.Init();
            DemoD_DbFirst.Init(); ;
            DemoE_CodeFirst.Init();
            DemoF_Utilities.Init();
            DemoG_SimpleClient.Init();
            DemoJ_Report.Init();
            //Unit test
            //NewUnitTest.Init();

            //Rest Data
            NewUnitTest.RestData();

            Console.WriteLine("all successfully.");
            Console.ReadKey();
        }

 
    }
}
