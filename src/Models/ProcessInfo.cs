public class ProcessInfo
{
    public int ProcessId { get; set; }
    public string ProcessName { get; set; }
    public double CpuUsagePercent { get; set; } 
    public System.TimeSpan CpuTime { get; set; } 
    public long MemoryUsageBytes { get; set; } 
    public long DiskBytesPerSec { get; set; } 
    public long NetworkBytesPerSec { get; set; } 
}
