/* CREATE TABLE */
CREATE TABLE dbo.shelter(
ID Int PRIMARY KEY,
s_Name VARCHAR(500),
Address_2 VARCHAR(500),
Suburb VARCHAR(100),
Longitude VARCHAR(100),
Latitude VARCHAR(100)
);

/* INSERT QUERY NO: 1 */
INSERT INTO [dbo].[shelter] ([ID], [s_Name], [Address_2], [Suburb], [Longitude], [Latitude]) VALUES (1, N'614/AMP Youth Bus', N'Bus located corner Swanston and Flinders Streets - Mobile service please check provider''s website for updated location', N'Melbourne', N'144.967553', N'-37.817291')

/* INSERT QUERY NO: 2 */
INSERT INTO dbo.shelter(ID, s_Name, Address_2, Suburb, Longitude, Latitude)
VALUES
(
2, 'Aboriginal Family Violence Prevention and Legal Service Victoria', '70-80 Wellington Street', 'Collingwood', 144.986299, -37.806427
);

/* INSERT QUERY NO: 3 */
INSERT INTO dbo.shelter(ID, s_Name, Address_2, Suburb, Longitude, Latitude)
VALUES
(
3, 'Action Centre', '92-94 Elizabeth Street', 'Melbourne', 144.96417, -37.815731
);

/* INSERT QUERY NO: 4 */
INSERT INTO dbo.shelter(ID, s_Name, Address_2, Suburb, Longitude, Latitude)
VALUES
(
4, 'Adult Outreach Support Services', '179 Flemington Road', 'North Melbourne', 144.948507, -37.795439
);

/* INSERT QUERY NO: 5 */
INSERT INTO dbo.shelter(ID, s_Name, Address_2, Suburb, Longitude, Latitude)
VALUES
(
5, 'AL–ANON Family Groups', '51 Queen Street', 'Melbourne', 144.961614, -37.817738
);

/* INSERT QUERY NO: 6 */
INSERT INTO dbo.shelter(ID, s_Name, Address_2, Suburb, Longitude, Latitude)
VALUES
(
6, 'Alcoholics Anonymous Victoria', '36 Church Street', 'Richmond', 145.000307, -37.811648
);

/* INSERT QUERY NO: 7 */
INSERT INTO dbo.shelter(ID, s_Name, Address_2, Suburb, Longitude, Latitude)
VALUES
(
7, 'Anglicare Victoria – Lazarus Centre', '15 Gisborne Street', 'East Melbourne', 144.975486, -37.80991
);

/* INSERT QUERY NO: 8 */
INSERT INTO dbo.shelter(ID, s_Name, Address_2, Suburb, Longitude, Latitude)
VALUES
(
8, 'Anglicare Victoria – Mission House', '122 Napier Street', 'Fitzroy', 144.97996, -37.804544
);

/* INSERT QUERY NO: 9 */
INSERT INTO dbo.shelter(ID, s_Name, Address_2, Suburb, Longitude, Latitude)
VALUES
(
9, 'Anglicare Victoria – St.Mark’s Community Centre', '250 George Street', 'Fitzroy', 144.981835, -37.801611
);

/* INSERT QUERY NO: 10 */
INSERT INTO dbo.shelter(ID, s_Name, Address_2, Suburb, Longitude, Latitude)
VALUES
(
10, 'Brotherhood of St Laurence Coolibah Centre', '67A Brunswick Street', 'Fitzroy', 144.977265, -37.805286
);
