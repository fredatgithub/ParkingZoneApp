﻿using ParkingZoneApp.Enums;
using ParkingZoneApp.Models;
using System.ComponentModel.DataAnnotations;

namespace ParkingZoneApp.ViewModels.ParkingSlotViewModels;

public class CreateViewModel
{
    [Required]
    public int Id { get; set; }
    [Required]
    public int Number { get; set; }
    [Required]
    public bool IsAvailableForBooking { get; set; }
    [Required]
    public int ParkingZoneId { get; set; }
    [Required]
    public SlotCategory Category { get; set; }

    public ParkingSlot MapToModel()
    {
        return new ParkingSlot
        {
            Id = Id,
            Number = Number,
            IsAvailableForBooking = IsAvailableForBooking,
            ParkingZoneId = ParkingZoneId,
            Category = Category
        };
    }

}
