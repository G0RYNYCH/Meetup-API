using Meetups.Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Meetups.Aplication.Interfaces
{
    public interface ITest
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
