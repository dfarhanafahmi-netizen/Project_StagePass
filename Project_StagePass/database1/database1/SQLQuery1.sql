-- STAGEPASS DATABASE - FULL SCRIPT
-- Run this once, everything created

-- Drop existing tables (if any)
DROP TABLE IF EXISTS [dbo].[Tickets];
DROP TABLE IF EXISTS [dbo].[Bookings];
DROP TABLE IF EXISTS [dbo].[TicketPackages];
DROP TABLE IF EXISTS [dbo].[Concerts];
DROP TABLE IF EXISTS [dbo].[Users];
DROP TABLE IF EXISTS [dbo].[Venues];

-- Create Venues
CREATE TABLE [dbo].[Venues]
(
    [VenueId]        NVARCHAR(10)  NOT NULL PRIMARY KEY,
    [VenueName]      NVARCHAR(100) NOT NULL,
    [Location]       NVARCHAR(100) NOT NULL,
    [City]           NVARCHAR(50)  NOT NULL,
    [TotalCapacity]  INT           NOT NULL
);

-- Create Concerts
CREATE TABLE [dbo].[Concerts]
(
    [ConcertId]   NVARCHAR(10)  NOT NULL PRIMARY KEY,
    [ArtistName]  NVARCHAR(100) NOT NULL,
    [TourName]    NVARCHAR(100) NULL,
    [ConcertDate] DATE          NOT NULL,
    [ConcertTime] TIME          NOT NULL, 
    [VenueId]     NVARCHAR(10)  NOT NULL,
    FOREIGN KEY ([VenueId]) REFERENCES [Venues]([VenueId])
);

-- Create TicketPackages
CREATE TABLE [dbo].[TicketPackages]
(
    [PackageId]          NVARCHAR(10)   NOT NULL PRIMARY KEY,
    [ConcertId]          NVARCHAR(10)   NOT NULL,
    [PackageName]        NVARCHAR(50)   NOT NULL,
    [Price]              DECIMAL(10,2)  NOT NULL,
    [AvailableSeats]     INT            NOT NULL,
    [PerksDescription]   NVARCHAR(200)  NULL,
    FOREIGN KEY ([ConcertId]) REFERENCES [Concerts]([ConcertId])
);

-- Create Users
CREATE TABLE [dbo].[Users]
(
    [UserId]       INT            NOT NULL PRIMARY KEY IDENTITY(1,1),
    [FullName]     NVARCHAR(100)  NOT NULL,
    [Email]        NVARCHAR(100)  NOT NULL UNIQUE,
    [PhoneNumber]  NVARCHAR(15)   NOT NULL
);

-- Create Bookings
CREATE TABLE [dbo].[Bookings]
(
    [BookingId]      INT            NOT NULL PRIMARY KEY IDENTITY(1,1),
    [UserId]         INT            NOT NULL,
    [ConcertId]      NVARCHAR(10)   NOT NULL,
    [BookingDate]    DATETIME       NOT NULL,
    [TotalAmount]    DECIMAL(10,2)  NOT NULL,
    [PaymentStatus]  NVARCHAR(20)   NOT NULL,
    FOREIGN KEY ([UserId]) REFERENCES [Users]([UserId]),
    FOREIGN KEY ([ConcertId]) REFERENCES [Concerts]([ConcertId])
);

-- Create Tickets
CREATE TABLE [dbo].[Tickets]
(
    [TicketId]      INT            NOT NULL PRIMARY KEY IDENTITY(1,1),
    [BookingId]     INT            NOT NULL,
    [PackageId]     NVARCHAR(10)   NOT NULL,
    [SeatNumber]    NVARCHAR(20)   NULL,
    [Zone]          NVARCHAR(50)   NULL,
    [QrCode]        NVARCHAR(200)  NULL,
    FOREIGN KEY ([BookingId]) REFERENCES [Bookings]([BookingId]),
    FOREIGN KEY ([PackageId]) REFERENCES [TicketPackages]([PackageId])
);

-- Insert Sample Data
INSERT INTO Venues VALUES ('VEN001', 'National Stadium', 'Bukit Jalil', 'Kuala Lumpur', 85000);
INSERT INTO Venues VALUES ('VEN002', 'Arena of Stars', 'Genting Highlands', 'Pahang', 6000);

INSERT INTO Concerts VALUES ('CONC101', 'The Weeknd', 'After Hours til Dawn', '2025-02-15', '20:00:00', 'VEN001');
INSERT INTO Concerts VALUES ('CONC102', 'BTS', 'Yet To Come', '2025-03-10', '19:30:00', 'VEN001');

INSERT INTO TicketPackages VALUES ('PKG001', 'CONC101', 'Ultimate VIP', 1200.00, 150, 'Exclusive merch');
INSERT INTO TicketPackages VALUES ('PKG002', 'CONC101', 'Gold VIP', 800.00, 500, 'Early entry');
INSERT INTO TicketPackages VALUES ('PKG003', 'CONC101', 'Hot Seat', 350.00, 2000, NULL);
INSERT INTO TicketPackages VALUES ('PKG004', 'CONC101', 'General Admission', 180.00, 5000, NULL);

INSERT INTO Users VALUES ('Ahmad Faiz', 'ahmad@email.com', '012-3456789');
INSERT INTO Users VALUES ('Siti Nur', 'siti@email.com', '013-9876543');

INSERT INTO Bookings VALUES (1, 'CONC101', '2025-01-10 14:30:00', 2000.00, 'Completed');
INSERT INTO Bookings VALUES (2, 'CONC101', '2025-01-10 15:45:00', 350.00, 'Completed');

INSERT INTO Tickets VALUES (1, 'PKG001', 'A12', 'VIP Zone', NULL);
INSERT INTO Tickets VALUES (1, 'PKG001', 'A13', 'VIP Zone', NULL);
INSERT INTO Tickets VALUES (2, 'PKG003', 'G45', 'Hot Seat', NULL);