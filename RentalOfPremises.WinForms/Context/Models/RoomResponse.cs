﻿using System;

namespace RentalOfPremises.WinForms.Context.Models
{
    /// <summary>
    /// Модель ответа помещения
    /// </summary>
    public class RoomResponse
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Литер
        /// </summary>
        public string Liter { get; set; } = string.Empty;

        /// <summary>
        /// Номер помещения
        /// </summary>
        public int NumberRoom { get; set; }

        /// <summary>
        /// Площадь
        /// </summary>
        public double SquareRoom { get; set; }

        /// <summary>
        /// Тип помещения
        /// </summary>
        public string TypeRoom { get; set; } = string.Empty;

        /// <summary>
        /// Занято ли помещение
        /// </summary>
        public bool Occupied { get; set; }

        /// <summary>
        /// Литер - Номер
        /// </summary>
        public string LiterNumber { get; set; } = string.Empty;

        public void InitLiterNumber()
        {
            LiterNumber = $"{Liter} - {NumberRoom}";
        }
    }
}
