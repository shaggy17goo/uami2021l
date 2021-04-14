namespace Doctors.Domain.DoctorAggregate
{
    using System;

    public class Certification 
    {
        public int CertificationId { get; private set; }
        public DateTime GrantedAt { get; private set; }
        public int Type {get; private set;}

        public Certification(int Id, DateTime grantedAt, int type)
        {
            CertificationId = Id;
            GrantedAt = grantedAt;
            Type = type;
        }
    }
}
