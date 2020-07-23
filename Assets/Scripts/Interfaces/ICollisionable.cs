using System;

namespace DataSakuraBikeRace
{
    public interface ICollisionable
    {
        Action OnCollisionEnterHandler { get; set; }
    }
}
