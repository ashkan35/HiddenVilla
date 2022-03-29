﻿namespace HiddenVilla_Server.Model
{
    public class BlazorRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public List<BlazorRoomProps> Properties { get; set; }
    }
}