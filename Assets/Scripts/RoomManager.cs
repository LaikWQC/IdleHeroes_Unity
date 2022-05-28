using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    [SerializeField] HeroData _heroPf;
    [SerializeField] Room _roomPf;
    [SerializeField] Transform _hereosFolder;
    [SerializeField] Transform _roomsFolder;

    private List<Room> _rooms = new List<Room>();

    public void CreateHero()
    {
        var hero = Instantiate(_heroPf, _hereosFolder);
        hero.Init();
        var room = Instantiate(_roomPf, _roomsFolder);
        _rooms.Add(room);
        room.Init(hero);
    }
}
