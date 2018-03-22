using System;
using System.Collections.Generic;
using System.Text;

namespace ETCarsDotNetSdk.Entities
{
    public struct ETCarsDataStatus
    {
        public const string INITIALIZED = "INITIALIZED";
        public const string PAUSED = "PAUSED";
        public const string UNPAUSED = "UNPAUSED";
        public const string TELEMETRYSHUTDOWN = "TELEMETRY SHUT DOWN";
        public const string JOBFINISHED = "JOB FINISHED";
        public const string JOBSTARTED = "JOB STARTED";
        public const string TELEMETRY = "TELEMETRY";
        public const string COLLISION = "COLLISION";
    }

    public class ETCarsDataContainer
    {
        public ETCarsData data { get; set; }
    }

    public class ETCarsData
    {
        public string status { get; set; }
        public ETCarsTelemetry telemetry { get; set; }
        public ETCarsJobdata jobData { get; set; }
        public ETCarsOffense offense { get; set; }
    }

    public class ETCarsTelemetry
    {
        public ETCarsPluginVersion pluginVersion { get; set; }
        public ETCarsGame game { get; set; }
        public ETCarsTruck truck { get; set; }
        public ETCarsNavigation navigation { get; set; }
        public ETCarsJob job { get; set; }
        public ETCarsTrailer trailer { get; set; }
        public ETCarsUser user { get; set; }
    }

    public class ETCarsPluginVersion
    {
        public int majorVersion { get; set; }
        public int minorVersion { get; set; }
        public string pluginVersionOnlyStr { get; set; }
    }

    public class ETCarsGame
    {
        public bool isMultiplayer { get; set; }
        public bool paused { get; set; }
        public bool isDriving { get; set; }
        public int majorVersion { get; set; }
        public int minorVersion { get; set; }
        public string gameID { get; set; }
        public string gameName { get; set; }
        public string gameVersionStr { get; set; }
        public string gameVersionOnly { get; set; }
        public Int64 nextRestStop { get; set; }
        public Int64 gameDateTime { get; set; }
        public string gameDayTime { get; set; }
        public string gameDateTimeStr { get; set; }
        public string osEnvironment { get; set; }
        public string architecture { get; set; }
        public int localScale { get; set; }
        public string[] substances { get; set; }
    }

    public class ETCarsTruck
    {
        public int cruiseControlSpeed { get; set; }
        public int gear { get; set; }
        public int gearDisplayed { get; set; }
        public int retarderBrakeLevel { get; set; }
        public bool wipersOn { get; set; }
        public string make { get; set; }
        public string makeID { get; set; }
        public string model { get; set; }
        public string modelID { get; set; }
        public string shifterType { get; set; }
        public float odometer { get; set; }
        public bool hasTruck { get; set; }
        public bool engineEnabled { get; set; }
        public bool electricsEnabled { get; set; }
        public bool motorBrake { get; set; }
        public bool parkingBrake { get; set; }
        public float speed { get; set; }
        public float engineRPM { get; set; }
        public float brakeTemperature { get; set; }
        public float fuelRange { get; set; }
        public float oilPressure { get; set; }
        public float oilTemperature { get; set; }
        public float waterTemperature { get; set; }
        public float batteryVoltage { get; set; }
        public float inputSteering { get; set; }
        public float inputThrottle { get; set; }
        public float inputBrake { get; set; }
        public float inputClutch { get; set; }
        public float effectiveSteering { get; set; }
        public float effectiveThrottle { get; set; }
        public float effectiveBrake { get; set; }
        public float effectiveClutch { get; set; }
        public float hShifterSlot { get; set; }
        public float brakeAirPressure { get; set; }
        public float adBlue { get; set; }
        public float dashboardBacklight { get; set; }
        public float maxEngineRPM { get; set; }
        public float forwardGearCount { get; set; }
        public float reverseGearCount { get; set; }
        public float retarderStepCount { get; set; }
        public bool trailerConnected { get; set; }
        public ETCarsWorldPlacement worldPlacement { get; set; }
        public ETCarsLinearVelocity linearVelocity { get; set; }
        public ETCarsAngularVelocity angularVelocity { get; set; }
        public ETCarsLinearAcceleration linearAcceleration { get; set; }
        public ETCarsAngularAcceleration angularAcceleration { get; set; }
        public ETCarsCabiOffset cabinOffset { get; set; }
        public ETCarsHookPosition hookPosition { get; set; }
        public ETCarsHeadPosition headPosition { get; set; }
        public ETCarsCabinAngularVelocity cabinAngularVelocity { get; set; }
        public ETCarsCabinAngularAcceleration cabinAngularAcceleration { get; set; }
        public float[] forwardRatios { get; set; }
        public float[] reverseRatios { get; set; }
        public int wheelCount { get; set; }
        public ETCarsWheelInfo[] wheelInfo { get; set; }
        public ETCarsTrailerPlacement trailerPlacement { get; set; }
        public ETCarsWarnings warnings { get; set; }
        public ETCarsDamages damages { get; set; }
        public ETCarsLights lights { get; set; }
        public ETCarsFuel fuel { get; set; }
    }

    public class ETCarsCoordinates
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }

    public class ETCarsPlacement : ETCarsCoordinates
    {
        public float heading { get; set; }
        public float pitch { get; set; }
        public float roll { get; set; }
    }

    public class ETCarsWorldPlacement : ETCarsPlacement
    {

    }

    public class ETCarsLinearVelocity : ETCarsCoordinates
    {
    }

    public class ETCarsAngularVelocity : ETCarsCoordinates
    {
    }

    public class ETCarsLinearAcceleration : ETCarsCoordinates
    {
    }

    public class ETCarsAngularAcceleration : ETCarsCoordinates
    {
    }

    public class ETCarsCabiOffset : ETCarsPlacement
    {
    }

    public class ETCarsHookPosition : ETCarsCoordinates
    {
    }

    public class ETCarsHeadPosition : ETCarsCoordinates
    {
    }

    public class ETCarsCabinAngularVelocity : ETCarsCoordinates
    {
    }

    public class ETCarsCabinAngularAcceleration : ETCarsCoordinates
    {
    }

    public class ETCarsTrailerPlacement : ETCarsPlacement
    {
    }

    public class ETCarsWarnings
    {
        public bool batteryVoltage { get; set; }
        public bool airPressure { get; set; }
        public bool airPressureEmergency { get; set; }
        public bool oilPressure { get; set; }
        public bool waterTemperature { get; set; }
        public bool fuelLow { get; set; }
        public bool adBlue { get; set; }
    }

    public class ETCarsDamages
    {
        public float engine { get; set; }
        public float transmission { get; set; }
        public float cabin { get; set; }
        public float chassis { get; set; }
        public float wheels { get; set; }
        public float trailer { get; set; }
    }

    public class ETCarsLights
    {
        public bool lowBeam { get; set; }
        public bool highBeam { get; set; }
        public int frontAux { get; set; }
        public bool beacon { get; set; }
        public bool parking { get; set; }
        public bool brake { get; set; }
        public bool reverse { get; set; }
        public bool leftBlinkerEnabled { get; set; }
        public bool rightBlinkerEnabled { get; set; }
        public bool leftBlinkerOn { get; set; }
        public bool rightBlinkerOn { get; set; }
        public int roofAux { get; set; }
    }

    public class ETCarsFuel
    {
        public float capacity { get; set; }
        public float warningLevel { get; set; }
        public float consumptionAverage { get; set; }
        public float currentLitres { get; set; }
    }

    public class ETCarsWheelInfo
    {
        public float suspensionDeflection { get; set; }
        public bool onGround { get; set; }
        public string substance { get; set; }
        public float angularVelocity { get; set; }
        public float lift { get; set; }
        public float liftOffset { get; set; }
        public ETCarsPosition position { get; set; }
        public bool steerable { get; set; }
        public bool simulated { get; set; }
        public float radius { get; set; }
        public float steering { get; set; }
        public float rotation { get; set; }
        public bool powered { get; set; }
        public bool liftable { get; set; }
    }

    public class ETCarsPosition : ETCarsCoordinates
    {
    }

    public class ETCarsNavigation
    {
        public float distance { get; set; }
        public Int64 time { get; set; }
        public float lowestDistance { get; set; }
        public float speedLimit { get; set; }
    }

    public class ETCarsJob
    {
        public string cargoID { get; set; }
        public string cargo { get; set; }
        public float mass { get; set; }
        public float income { get; set; }
        public string destinationCityID { get; set; }
        public string destinationCity { get; set; }
        public string destinationCompanyID { get; set; }
        public string destinationCompany { get; set; }
        public string sourceCityID { get; set; }
        public string sourceCity { get; set; }
        public string sourceCompanyID { get; set; }
        public string sourceCompany { get; set; }
        public Int64 deliveryTime { get; set; }
        public bool isLate { get; set; }
        public Int64 timeRemaining { get; set; }
        public bool onJob { get; set; }
    }

    public class ETCarsTrailer
    {
        public ETCarsLinearVelocity linearVelocity { get; set; }
        public ETCarsAngularVelocity angularVelocity { get; set; }
        public ETCarsLinearAcceleration linearAcceleration { get; set; }
        public ETCarsAngularAcceleration angularAcceleration { get; set; }
        public int wheelCount { get; set; }
        public ETCarsWheelInfo[] wheelInfo { get; set; }
        public string id { get; set; }
        public string cargoAccessoryId { get; set; }
        public ETCarsHookPosition hookPosition { get; set; }
    }

    public class ETCarsUser
    {
        public string steamID { get; set; }
        public string steamUsername { get; set; }
        public ETCarsDLCList DLC { get; set; }
    }

    public class ETCarsDLCList
    {
        public ETCarsDLC[] DLC { get; set; }
    }

    public class ETCarsDLC
    {
        public string appid { get; set; }
        public string name { get; set; }
        public bool available { get; set; }
        public bool installed { get; set; }
    }

    public class ETCarsJobdata
    {
        public int status { get; set; }
        public bool wasSpeeding { get; set; }
        public bool jobStartedEventFired { get; set; }
        public bool isMultiplayer { get; set; }
        public bool late { get; set; }
        public bool onJob { get; set; }
        public bool wasFinished { get; set; }
        public bool wasTrailerDisconnected { get; set; }
        public string sourceCity { get; set; }
        public string sourceCompany { get; set; }
        public string destinationCity { get; set; }
        public string destinationCompany { get; set; }
        public string cargo { get; set; }
        public string truckMake { get; set; }
        public string truckModel { get; set; }
        public string game { get; set; }
        public string sourceCityID { get; set; }
        public string sourceCompanyID { get; set; }
        public string destinationCityID { get; set; }
        public string destinationCompanyID { get; set; }
        public string cargoID { get; set; }
        public string truckMakeID { get; set; }
        public string truckModelID { get; set; }
        public string gameID { get; set; }
        public string gameVersion { get; set; }
        public string pluginVersion { get; set; }
        public float topSpeed { get; set; }
        public float speedingCount { get; set; }
        public float income { get; set; }
        public float trailerMass { get; set; }
        public float distanceDriven { get; set; }
        public float fuelBurned { get; set; }
        public float fuelPurchased { get; set; }
        public float startOdometer { get; set; }
        public float endOdometer { get; set; }
        public Int64 timeRemaining { get; set; }
        public Int64 timeStarted { get; set; }
        public Int64 timeDue { get; set; }
        public Int64 timeDelivered { get; set; }
        public float collisionCount { get; set; }
        public float finishTrailerDamage { get; set; }
        public float startTrailerDamage { get; set; }
        public float deliveryX { get; set; }
        public float deliveryY { get; set; }
        public float deliveryZ { get; set; }
        public float pickupX { get; set; }
        public float pickupY { get; set; }
        public float pickupZ { get; set; }
        public float trailerDeliveryX { get; set; }
        public float trailerDeliveryY { get; set; }
        public float trailerDeliveryZ { get; set; }
        public float trailerPickupX { get; set; }
        public float trailerPickupY { get; set; }
        public float trailerPickupZ { get; set; }
        public float startEngineDamage { get; set; }
        public float startTransmissionDamage { get; set; }
        public float startCabinDamage { get; set; }
        public float startChassisDamage { get; set; }
        public float startWheelDamage { get; set; }
        public float finishEngineDamage { get; set; }
        public float finishTransmissionDamage { get; set; }
        public float finishCabinDamage { get; set; }
        public float finishChassisDamage { get; set; }
        public float finishWheelDamage { get; set; }
        public float totalEngineDamage { get; set; }
        public float totalTransmissionDamage { get; set; }
        public float totalCabinDamage { get; set; }
        public float totalChassisDamage { get; set; }
        public float totalWheelDamage { get; set; }
        public float totalTrailerDamage { get; set; }
        public float navigationDistanceRemaining { get; set; }
        public float fuel { get; set; }
        public float odometer { get; set; }
        public float engineDamage { get; set; }
        public float transmissionDamage { get; set; }
        public float cabinDamage { get; set; }
        public float chassisDamage { get; set; }
        public float wheelDamage { get; set; }
        public float trailerDamage { get; set; }
        public Int64 realTimeStarted { get; set; }
        public Int64 realTimeEnded { get; set; }
        public Int64 realTimeTaken { get; set; }
    }

    public class ETCarsOffense : ETCarsCoordinates
    {
        public string reason { get; set; }
        public float speed { get; set; }
        public float speedLimit { get; set; }
        public float trailerX { get; set; }
        public float trailerY { get; set; }
        public float trailerZ { get; set; }
        public float cabinDamage { get; set; }
        public float chassisDamage { get; set; }
        public float engineDamage { get; set; }
        public float transmissionDamage { get; set; }
        public float trailerDamage { get; set; }
    }

}
