using HouseRenting.Contracts;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Text.RegularExpressions;

namespace HouseRenting.Infrastructure
{
    public static class ModelExtensions
    {
        public static string GetInformation(this IHouseModel house)
        {
            return house.Title.Replace(" ", "-") + "-" + GetAddress(house.Address);
        }

        public static string GetAddress(string address)
        {
            address = String.Join("-", address.Split(" ").Take(3));
            return Regex.Replace(address, @"[^a-zA-Z0-9\-]", string.Empty);
        }
    }
}
