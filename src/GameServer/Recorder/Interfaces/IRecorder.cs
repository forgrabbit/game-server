using GameServer.GameLogic;
using LevelDB;

namespace GameServer.Recorder;

public interface IRecorder
{
    public DB? LevelDB { get; }

    public void CreateNewRecord(string recordName);
    public void RecordInitialInformation(IGame game);
    public void RecordEvents(EventArgs e);
}
