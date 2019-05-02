
using System;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityStandardAssets.Characters.FirstPerson;
using System.Diagnostics;
using System.Threading;
using System.ComponentModel;
using System.Text;
using System.Runtime.InteropServices;

public class task_meg : MonoBehaviour
{

    [DllImport("inpoutx64.dll")]
    private static extern UInt32 IsInpOutDriverOpen();

    [DllImport("inpoutx64.dll")]
    private static extern void Out32(int PortAddress, int Data);

}