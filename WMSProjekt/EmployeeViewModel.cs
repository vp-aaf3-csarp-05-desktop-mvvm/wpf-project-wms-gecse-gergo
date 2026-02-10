namespace WMSProjekt
{
    /// <summary>
    /// Dolgozó adatok megjelenéshez (szabadnapkezelés)
    /// </summary>
    public class EmployeeViewModel
    {
        /// <summary>
        /// Dolgozó neve
        /// </summary>
        public string Name { get; } = "Nagy anna";

        /// <summary>
        /// Adószám (11)
        /// </summary>
        public string TaxNumber { get; } = "12345678-1-42";

        /// <summary>
        /// Kivett szabadnapok száma
        /// </summary>
        public int Daysoff { get; } = 6;
    }
}
