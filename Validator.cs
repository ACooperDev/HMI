using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace HMI
{
    //Checks the bios serial number to verify whether user is allowed access to AlexLib.
    public class Validator
    {
        //Returns a true or false based on the serial number of the bios.
        //A user can check their BIOS serial number by running Command Prompt as an administrator and typing in:
        //wmic bios get serialnumber
        public Boolean Check()
        {
            //The customer BIOS serial number to check against.
            string customerSerialNumber = "HDC8P73";

            //Default the result to false.
            Boolean result = false;

            //Select the serial number, BIOS version and BIOS release date from the machine and pass the results into a collection.
            ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("SELECT SerialNumber, SMBIOSBIOSVersion, ReleaseDate FROM Win32_BIOS");
            ManagementObjectCollection collection = mSearcher.Get();

            //Loop through the collection and check any serial numbers found against the customerSerialNumber.
            //If a match is found, set the result to true otherwise set it to false.
            foreach (ManagementObject obj in collection)
            {
                if (customerSerialNumber == (string)obj["SerialNumber"])
                {
                    result = true;
                    break;
                }
                else
                {
                    result = false;
                }
            }
            mSearcher.Dispose();
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}