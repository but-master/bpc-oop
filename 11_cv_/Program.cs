// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Microsoft.EntityFrameworkCore;
using _11_cv_.EFCore;
using System;

using (var context = new VyukaContext())
{
    context.Database.Migrate();

    //context.Predmets.Add(new Predmet() { Nazev = "Objektove orientovane programovani" });

    fillUp();

    context.SaveChanges();

    StudentiPredmetu(context, "OOP");

    PredmetyStudenta(context, 1000);

    void fillUp()
    {
        //studenti
        if (!context.Students.Any(s => (s.StudentId == 1000)))
        {
            context.Students.Add(new Student() { Jmeno = "Josef", Prijmeni = "Novák", DatumNarozeni = new DateTime(1995, 1, 1) });
        }
        //StudentId = 1000

        //predmety
        if (!context.Predmets.Any(s => s.PredmetId == "OOP"))
        {
            context.Predmets.Add(new Predmet() { PredmetId = "OOP", Nazev = "Objektove orientovane programovani" });
        }

        //StudentPredmet
        if (!context.StudentPredmets.Any(s => s.IdStudent == 1000 && s.ZkratkaPredmet == "OOP"))
        {
            context.StudentPredmets.Add(new StudentPredmet() { IdStudent = 1000, ZkratkaPredmet = "OOP" });
        }

        //hodnoceni
        if (!context.Hodnocenis.Any(s => s.IdStudent == 1000 && s.ZkratkaPredmet == "OOP"))
        {
            context.Hodnocenis.Add(new Hodnoceni() { IdStudent = 1000, ZkratkaPredmet = "OOP", Datum = new DateTime(2015, 5, 1), Znamka = 2 });
        }
    }

    static IEnumerable<Student> StudentiPredmetu(VyukaContext context, string predmtId)
    {
        return from sp in context.StudentPredmets
               join s in context.Students on sp.IdStudent equals s.StudentId
               where sp.ZkratkaPredmet == predmtId
               select s;
    }

    static IEnumerable<Predmet> PredmetyStudenta(VyukaContext context, int studentId)
    {
        return from sp in context.StudentPredmets
               join p in context.Predmets on sp.ZkratkaPredmet equals p.PredmetId
               where sp.IdStudent.Equals(studentId)
               select p;
    }

}