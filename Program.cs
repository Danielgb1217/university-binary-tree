 using System;

namespace university_binary_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position("rector", 1000);
            Position vicFinPosition = new Position("Vicerector", 750);
            Position vicAcadPosition = new Position("Vicerector academico", 780);
            Position contadorPosition = new Position("contador", 500);
            Position jefeFinPosition = new Position("jefe financiero", 610);
            Position secFin1Position = new Position("secretaria financiera 1", 350);
            Position secFin2Position = new Position("secretaria financiera 2", 310);


            Position jefeRegPosition = new Position("sjefe reg", 640);
            Position asist2Position = new Position("Asistente 2", 170);
            Position secTreg2Position = new Position("secretaria Treg 1", 360);            
            Position secTreg1Position = new Position("secretaria Treg 2", 400);
            Position mensajeroPosition = new Position("Mensajero", 90);
            Position asist1Position = new Position("Asistente 1", 250);





            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, vicFinPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);           
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);

            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);


            universityTree.CreatePosition(universityTree.Root, vicAcadPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, vicAcadPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secTreg2Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secTreg1Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asist2Position, secTreg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajeroPosition, asist2Position.Name);
            universityTree.CreatePosition(universityTree.Root, asist1Position, secTreg1Position.Name);


            


            universityTree.PrintTree(universityTree.Root);

            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"Total Salaries : {totalSalary}");

            Console.ReadLine();
        }
    }
}
