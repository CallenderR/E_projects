using E_APP02.VIEW.JOB_VIEW.JOB_SELECTION_VIEW;

namespace E_APP02.VIEW.JOB_VIEW.JOB_MAIN_VIEW
{
    internal class Job_Main_View01
    {
        private static string[] data01 = new string[100];
        public Job_Main_View01()
        {
            load_Job_Main_View01().Wait();
        }
        private async Task load_Job_Main_View01()
        {
            data01[0] = $"Select View\n" +
$"-------------------------\n" +
$"1.) job 01 \n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            switch (int.Parse(data01[1]))
            {
                case 1:
                    new Job_View01();
                    break;

            }
        }
    }
}
