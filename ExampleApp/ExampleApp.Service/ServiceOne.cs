namespace ExampleApp.Service
{
  public class ServiceOne
  {
    public string DeviceName { get; set; }

    private void OnDeviceDiscovered()
    {
      this.DeviceName = "";
    }
  }
}