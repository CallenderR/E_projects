using E_APP02.SERVICES.JOB_SERVICES;

namespace E_APP02.VIEW.JOB_VIEW.JOB_SELECTION_VIEW
{
    internal class Job_View01
    {
        private static string[] data01 = new string[100];
        private static Job_Services01 Job_Serv01 = new Job_Services01();   
        public Job_View01()
        {
            load_Job_View01().Wait();
        }
        private async Task load_Job_View01()
        {

            data01[0] = $"Select View\n" +
$"-------------------------\n" +
$"1.) Job_Search \n" +
$"2.) Job_Salary \n" +
$"3.) Company_Job_Salary\n"
;
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    data01[2] = $"{Job_Serv01.data_array[0]}";
                    Console.WriteLine(data01[2]);
                    data01[3] = Console.ReadLine();
                    data01[4] = await Job_Serv01.Job_Search(data01[3]);
                    Console.WriteLine(data01[4]);
                    break;
                case 2:
                    data01[5] = $"{Job_Serv01.data_array[5]}";            
                    Console.WriteLine(data01[5]);
                    data01[6] = Console.ReadLine();
                    data01[7] = $"{Job_Serv01.data_array[6]}";
                    Console.WriteLine(data01[7]);
                    data01[8] = Console.ReadLine();
                    string[] resualts = { data01[6], data01[8] };
                    data01[9] = await Job_Serv01.Job_Salary(resualts);
                    Console.WriteLine(data01[9]);
                    break;
                case 3:
                    data01[10] = $"{Job_Serv01.data_array[7]}";
                    Console.WriteLine(data01[10]);
                    data01[11] = Console.ReadLine();
                    data01[12] = $"{Job_Serv01.data_array[5]}";
                    Console.WriteLine(data01[12]);
                    data01[13] = Console.ReadLine();
                    string[] resualts01 = { data01[11], data01[13]};
                    data01[14] =await Job_Serv01.Company_Job_Salary(resualts01);
                    Console.WriteLine(data01[14]);
                    break;


            }
        }
    }
}
