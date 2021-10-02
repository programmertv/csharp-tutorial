using System;
namespace Episode011
{
    public abstract class MobilePhone
    {
        private string _microChip;

        public string Shape { get; set; }
        public string Color { get; set; }

        public void PowerOn()
        {
            ConnectMainboardToPowerSupply();
            OpenWifiChip();
        }

        private void ConnectMainboardToPowerSupply() { }
        private void OpenWifiChip() { }
    }
}
