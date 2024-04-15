using System.ComponentModel;
using System.Runtime.Loader;

namespace logic_traning_lib._0014
    ;
internal class exercise
{

    /// <summary>
    /// https://leetcode.com/problems/defanging-an-ip-address/
    /// </summary>
    /// <param name="address"></param>
    /// <returns></returns>
    public string DefangIPaddr(string address)
    {
        return address.Replace(".", "[.]");
    }
}