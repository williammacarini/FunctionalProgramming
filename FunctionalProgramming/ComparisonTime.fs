module ComparisonTime
open System

type Period = { StartDate:DateTime; EndDate:DateTime }

let adicionaDias period increaseDays =
    { 
        StartDate = period.StartDate.AddDays increaseDays;
        EndDate = period.EndDate.AddDays increaseDays;
    }
   
let checkDatesIsBetween period (dateTest:DateTime) = 
    dateTest.CompareTo period.StartDate >= 0 && 
    dateTest.CompareTo period.EndDate <= 0    

