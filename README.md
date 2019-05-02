# parallel-port-c-unity


attached inpoutx64.dll is the matlab verison from http://apps.usd.edu/coglab/psyc770/IO64.html, it works with unity (c#) under x64 windows 10/windows 7 and communicate with parallel port.

To use, drag the DLL file into "assets" folder, and add the following code in your script.

    [DllImport("inpoutx64.dll")]
    private static extern void Out32(int PortAddress, int Data);

    [DllImport("inpoutx64.dll")]
    private static extern UInt32 IsInpOutDriverOpen();
    
    
![alt-text](https://github.com/ZHANGneuro/parallel-port-c-unity/blob/master/ezgif-5-54451896ded1.gif)



BTW, the verison of http://www.highrez.co.uk/downloads/inpout32/ did not work because it requires a data type of short as parameters, it would not work when the parallel port address is longer than 32,767.





