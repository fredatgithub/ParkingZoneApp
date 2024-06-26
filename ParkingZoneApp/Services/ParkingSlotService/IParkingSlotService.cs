﻿using ParkingZoneApp.Models;

namespace ParkingZoneApp.Services.ParkingSlotService;

public interface IParkingSlotService : IService<ParkingSlot>
{
    IEnumerable<ParkingSlot> GetSlotsByZoneId(int parkingZoneId);
    public bool IsExistingParkingSlot(int parkingZoneId, int slotNumber);
}
