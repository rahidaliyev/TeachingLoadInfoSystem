use TeachinLoad1
insert into Genders 
values('gc0001', N'Kisi'),
('gc0002',N'Qadin')



insert into ScientificDegrees
values
('sc0001',N't.e.n'),
('sc0002',N't.e.d'),
('sc0003',N'f-r.e.n'),
('sc0004',N'f-r.e.d'),
('sc0005',N'i.e.d')

insert into ScientificNames
values
('sn0001',N'Professor'),
('sn0002',N'Dosent'),
('sn0003',N'Akademik'),
('sn0004',N'Yoxdur')

insert into Professions
values
('pc0001','Professor'),
('pc0002','Dosent'),
('pc0003',N'Baş müəllim'),
('pc0004','Müəllim'),
('pc0005','Assistent')


insert into WorkTimes
values
('wc0001','Tam Ştat',1),
('wc0002','0.75 Ştat',0.75),
('wc0003','Yarım Ştat',0.5),
('wc0004','0.25 Ştat',0.25),
('wc0005','Saat Hesabı',0),
('wc0006','Müddətli müqavilə əsasında',0)

insert into Languages
values
('AZE','Azərbaycan'),
('ENG','İngilis'),
('TR','Türk'),
('RUS','Rus')

insert into TLIncludeds 
values
(N'Maliyyə və mühasibat','210','630','','','','840','','','','','','','','','','','','','840'),
(N'Beynəlxalq iqtisadiyyat məktəbi','','','','','','0','','','','','','','','','','','','','0'),
(N'Iqtisadiyyat','240','450','','','','690','','','','','','','','','','','','','690'),
(N'Rus iqtisadi məktəbi','210','375','','','','585','150','105','','','','','','','','','','255','840'),
(N'Rəqəmsal iqtisadiyyat','2490','3375','120','','','5985','2400','3360','120','','','','880','','300','','','7060','13045'),
(N'Mühəndislik','270','345','30','','','645','75','120','','','','','','','','','','195','840'),
(N'Bisnes və menecment','330','690','','','','1020','30','60','','','','','','','','','','90','1110'),
(N'Türk dünyası iqtisad','','','','','','0','','','','','','','','','','','','','0'),
(N'Distant, qiyabi və əlavə təhsil mərkəzi','590','','','','','590','362','','','','','','280','','','','','642','1232'),
(N'Sabah mərkəzi','','','','','','0','','','','','','','','','','','','','0'),
(N'Magistratura mərkəzi','1474','1524','','62','217','3277','480','510','','23','122','60','','180','','3480','','4855','8132'),
(N'Beynəlxalq magistratura və doktorantura mərkəzi','','','','','','0','','','','','','','','','','360','','360','360'),
(N'UNEC Biznes məktəbi MBA','','','','','','0','','','','','','','','','','40','','40','40'),
(N'Doktorantura','0','0','','','','0','','','','','','','','','','','250','250','250'),
(N'UNEC dizayn məktəbi','0','0','','','','0','90','105','','','','','','','','','','195','195')

insert into Departments
values
('dc0001',N'Rəqəmsal texnologiyalar və tətbiqi informatika'),
('dc0002',N'Mühəndislik və tətbiqi elmlər'),
('dc0003',N'Xarici dillər'),
('dc0004',N'Riyaziyyat və statistika'),
('dc0005',N'Azərbaycan dili'),
('dc0006',N'Humanitar fənnlər'),
('dc0007',N'Biznesin idarə edilməsi'),
('dc0008',N'Iqtisadiyyat_RUS'),
('dc0009',N'Riyaziyyat və statistika')

insert into TLExcludeds
values
(1,'2490','3375','120','','','5985','2400','3360','120','','','','880','','300','','','7060','13045'),
(2,'270','345','30','','','645','75','120','','','','','','','','','','195','840'),
(3,'590','','','','','590','362','','','','','','280','','','','','642','1232'),
(4,'','','','','','0','','','','','','','','','','','','','0'),
(5,'','','','','','0','','','','','','','','','','','','','0'),
(6,'330','690','','','','1020','30','60','','','','','','','','','','90','1110'),
(7,'240','450','','','','690','','','','','','','','','','','','','690'),
(8,'210','375','','','','585','150','105','','','','','','','','','','255','840'),
(9,'','','','','','0','','','','','','','','','','','','','0')

	
insert into TeacherInfos
values
('pc0003','Heyran','Həsənova','Rəhim','12-12-12','default@gmail.com','501110011',1,1,1,1,1,1),
('pc0004', N'Aida', N'Quliyeva', N'Aydın','12-12-12','default@gmail.com','501110011',1,1,1,1,1,1),
('pc0005', N'Sevda', N'Bədəlova', N'Ağababa','12-12-12','default@gmail.com','501110011',1,1,1,1,1,1),
('pc0006', N'Ceyran', N'Xəlilova', N'Musa','12-12-12','default@gmail.com','501110011',1,1,1,1,1,1),
('pc0007', N'Dilarə', N'Əbdüləziz', N'Abas','12-12-12','default@gmail.com','501110011',1,1,1,1,1,1),
('pc0008', N'Gülnar', N'Mirzəyeva', N'Rövşən','12-12-12','default@gmail.com','501110011',1,1,1,1,1,1),
('pc0009', N'Ülviyyə', N'Göyüşova', N'Malik','12-12-12','default@gmail.com','501110011',1,1,1,1,1,1),
('pc0010', N'Gülşən', N'Fərhadova', N'Mösüm','12-12-12','default@gmail.com','501110011',1,1,1,1,1,1),
('pc0011', N'Hafiz', N'Bayramov', N'Məhərrəv','12-12-12','default@gmail.com','501110011',1,1,1,1,1,1),
('pc0012', N'Haxverdi', N'Mənsimov', N'İsgəndər','12-12-12','default@gmail.com','501110011',1,1,1,1,1,1),
('pc0013', N'Həmdulla', N'Əsgərov', N'Əbil','12-12-12','default@gmail.com','501110011',1,1,1,1,1,1)

insert into Users
values
('sa',1)