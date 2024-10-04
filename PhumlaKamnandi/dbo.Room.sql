CREATE TABLE [dbo].[Room] (
    [RoomID]          INT           NOT NULL,
    [RoomType]        VARCHAR (100) NOT NULL,
    [RatePerNight]    DECIMAL (18)  NOT NULL,
    [OccupancyStatus] VARCHAR (20)  NOT NULL,
    PRIMARY KEY CLUSTERED ([RoomID] ASC)
);

