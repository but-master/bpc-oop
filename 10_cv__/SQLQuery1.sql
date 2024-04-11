--select *
--from Student


select S.Jmeno, S.Prijmeni, P.Nazev
from Student as S
left join StudentPredmet as SP on S.Id = SP.IdStudent
left join Predmet as P on SP.ZkratkaPredmet = P.Zkratka;


select Prijmeni, count(*) as PS
from Student
group by Prijmeni
order by PS desc;

select ZkratkaPredmet, count(*) as PS
from StudentPredmet
group by ZkratkaPredmet
having count(*) < 3;

select H.ZkratkaPredmet, min(H.Znamka) as NejlepsiHodnoceni, max(H.Znamka) as NejhorsiHodnoceni, avg(H.Znamka) as PrumerneHodnoceni, count(*) as PocetHodnocenych
from Hodnoceni as H
group by H.ZkratkaPredmet;
