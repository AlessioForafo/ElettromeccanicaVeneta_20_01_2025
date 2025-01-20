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

public class DesignTimeNetLogic1 : BaseNetLogic
{
    [ExportMethod]
    public void CreaAllarmi()
    {
        // Insert code to be executed by the method
        for (int i = 0; i < 100; i++)
        { 
            var mioAllarme = InformationModel.Make<DigitalAlarm>("Allarme_" + i);
            mioAllarme.Message = "Testo allarme " + i;
            Project.Current.Get("Alarms/AllarmiDaCodice").Add(mioAllarme);
        }

    }
}
