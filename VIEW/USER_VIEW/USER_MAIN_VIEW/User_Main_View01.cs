
namespace E_APP02.VIEW.USER_VIEW.USER_MAIN_VIEW
{
    internal class User_Main_View01
    {
        private static string[] data01 = new string[100];
        public User_Main_View01()
        {
            load_User_Main_View01().Wait();


        }
        private async Task load_User_Main_View01()
        {
            data01[0] = $"Select View\n" +
$"-------------------------\n" +
$"1.) User info using sql\n" +
$"2.) User info using sqlite\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine();
            if(int.Parse(data01[1])==1)
            {
                data01[2] = $"Select View\n" +
$"-------------------------\n" +
$"1.) User login using sql\n" +
$"2. Find User info using sql\n" +
$"3.) Creaet user Profile\n" +
$"4.) View all users";
                Console.WriteLine(data01[2]);
                data01[3] = Console.ReadLine();

                switch (int.Parse(data01[3]))
                {
                    case 1:
                        new E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQL.User_View01();
                        break;
                    case 2:
                        new E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQL.User_View02();
                        break;
                    case 3:
                        new E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQL.User_View02();
                        break;
                    case 4:
                        new E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQL.User_View03();
                        break;
                    case 5:
                        new E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQL.User_View04();
                        break;
                }
            


            }
            else if (int.Parse(data01[1]) == 1)
            {
                data01[2] = $"Select View\n" +
$"-------------------------\n" +
$"1.) User login using sqlite\n" +
$"2. Find User info using sqlite\n" +
$"3.) Creaet user Profile using sqlite\n" +
$"4.) View all users using sqlite";
                Console.WriteLine(data01[2]);
                data01[3] = Console.ReadLine();

                switch (int.Parse(data01[3]))
                {
                    case 1:
                        new E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQLITE.User_View01();
                        break;
                    case 2:
                        new E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQLITE.User_View02();
                        break;
                    case 3:
                        new E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQLITE.User_View02();
                        break;
                    case 4:
                        new E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQLITE.User_View03();
                        break;
                    case 5:
                        new E_APP02.VIEW.USER_VIEW.USER_SELECTION_VIEW.USER_VIEW_SQLITE.User_View04();
                        break;
                }
           
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }
    }
}