using GameServer.GameLogic;
using LevelDB;

namespace GameServer.Recorder;

public class Recorder : IRecorder
{
    public DB? LevelDB { get; private set; } = null;

    public void CreateNewRecord(string recordName)
    {
        LevelDB?.Close();
        var options = new Options { CreateIfMissing = true };
        LevelDB = new DB(options, recordName);
        throw new NotImplementedException();
    }
    public void RecordInitialInformation(IGame game)
    {
        throw new NotImplementedException();
    }

    public void RecordEvents(EventArgs e)
    {
        throw new NotImplementedException();
    }
}
