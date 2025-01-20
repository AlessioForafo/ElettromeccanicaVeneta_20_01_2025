#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.HMIProject;
using FTOptix.CoreBase;
using FTOptix.System;
using FTOptix.Retentivity;
using FTOptix.NetLogic;
using FTOptix.SerialPort;
using FTOptix.UI;
using FTOptix.Core;
using FTOptix.WebUI;
using FTOptix.Modbus;
using FTOptix.CommunicationDriver;
using FTOptix.CODESYS;
using FTOptix.Alarm;
using FTOptix.OPCUAServer;
using FTOptix.EventLogger;
using FTOptix.Store;
using FTOptix.SQLiteStore;
using FTOptix.DataLogger;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        for (int i = 0; i < 50; i++)
        {
            var mioRettangolo = InformationModel.Make<Rectangle>("Rettangolo_" + i);
            mioRettangolo.Height = 20;
            mioRettangolo.Width = 20;
            mioRettangolo.FillColor = Colors.Lime;
            Owner.Get("HorizontalLayout1").Add(mioRettangolo);
        }
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
    [ExportMethod]
    public void mioMetodo()
    {
        var variabilePLC = Project.Current.GetVariable("CommDrivers/ModbusDriver1/ModbusStation1/Tags/ModbusTag2");
        variabilePLC.Value = variabilePLC.Value + 1;
    }

}
