using System;

namespace Controllers
{
    public class DecisionTableController
    {

        public float GetReimburse(bool deductibleMet, TypeOfVisit visit)
        {
            var doctor = TypeOfVisit.Doctor;
            var hospital = TypeOfVisit.Hospital;

            if (deductibleMet == true && visit == doctor)
                return 0.5f;
            if (deductibleMet == true && visit == hospital)
                return 0.8f;
            if (deductibleMet == false && visit == doctor)
                return 0f;
            if (deductibleMet == false && visit == hospital)
                return 0f;
            else
                throw new Exception("Invalid Deductible or TypeOfVisit");
        }

    }

    public enum TypeOfVisit
    {
        Doctor,
        Hospital
    }
}
