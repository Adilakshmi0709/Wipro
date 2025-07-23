// //create a jagged array to store 5 student names and their subject
//  //like student 1 has taken 2 subjs , student 2 has taken 4 subjects and so on
// // by taking input from an user and then display


// using System; // using is a keyword to import the namespaces (package)

// class Program
// {

//    // method is in pascal case (eg : AddOperation())
//     static void Main()
//     {
//         Console.WriteLine("How many students of data you want to save : ");
//         int noOfStudent = Convert.ToInt32(Console.ReadLine());
//         //string[,] sName = new string[5,2];
//         string[] sName = new string[noOfStudent];
//         string[][] studentSubject = new string[noOfStudent][];

       
        
//         Console.WriteLine("Let's save name and their subjects of "+noOfStudent+" students :");

//         for (int i = 0; i < noOfStudent; i++)
//         {

//             Console.WriteLine("Enter name of student " + (i + 1));
//             sName[i] = Console.ReadLine();

//             Console.WriteLine("How many subjects you want to store ");
//             int subCount = Convert.ToInt32(Console.ReadLine());

//             studentSubject[i] = new string[subCount];
//             for (int j = 0; j < subCount; j++) 
//             {
//                 Console.WriteLine("Enter name of subject "+(j+1)+" : ");
//                 studentSubject[i][j] = Console.ReadLine();
//                 //Console.WriteLine(studentSubject[i][j]);
//             }

//         }
//          Console.WriteLine("Student Data name and subject wise :");
//         for (int i = 0; i < noOfStudent; i++)
//         {
//             Console.WriteLine("The student " + (i + 1) +"details are : \nName : " + sName[i]);
//             for (int j = 0; j < studentSubject[i].Length; j++)
//             {
//                 Console.WriteLine("Subject "+ (j + 1) +" : "+studentSubject[i][j]);
//             }

//         }

//     }


// }