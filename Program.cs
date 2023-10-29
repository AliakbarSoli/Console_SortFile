
//Get Path Directory For Order
Console.WriteLine("Please Enter the Path :");
string path = Console.ReadLine();

//Get Number To Create Folder
Console.WriteLine("Please Enter the Number Of Season :");
int LenFolder = Convert.ToInt32(Console.ReadLine());

//This If To Check The Correct Number
if (LenFolder > 0)
{
    //This If To Check The Correct Path
    if (Directory.Exists(path) == true)
    {



        Console.WriteLine("-----------------------------------------------------------------------");

        //Create DirectoryInfo For Search File
        DirectoryInfo di = new DirectoryInfo(path);

        //This For Loop To Create Folder
        for (global::System.Int32 i = 1; i <= LenFolder; i++)
        {

            //Create Folder By name file

            string Foldernamecombin = Path.Combine(path, "S" + i.ToString());
            Directory.CreateDirectory(Foldernamecombin);

            //Found file by Search part of name
            string SearchFile = Path.Combine("*" + "S0" + i.ToString() + "*");
            FileInfo[] subFiles = di.GetFiles(SearchFile, SearchOption.AllDirectories);

            //This For Loop To Move File
            for (global::System.Int32 j = 0; j < subFiles.Length; j++)
            {

                //Move File To New Directory

                string filenamecombinMove = Path.Combine(path, "S" + i.ToString(), subFiles[j].Name);
                FileInfo SubFile = new FileInfo(filenamecombinMove);
                FileInfo MainFile = new FileInfo(subFiles[j].FullName);
                File.Move(MainFile.FullName, SubFile.FullName);

            }

        }

        Console.WriteLine("Done");
        Environment.Exit(0);
    }
    else
    {
        //If Path Incorrect
        Console.WriteLine("Please Enter The Correct Path");
        Environment.Exit(0);
    }
}

else
{
    // If Path Incorrect
    Console.WriteLine("Please Enter The Correct Number");
    Environment.Exit(0);
}






