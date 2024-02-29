INSERT INTO [dbo].[lop] ([malop], [tenlop]) VALUES (N'a', N'Công nghệ')
INSERT INTO [dbo].[lop] ([malop], [tenlop]) VALUES (N'th205_2', N'Tin học 205.2')
INSERT INTO [dbo].[lop] ([malop], [tenlop]) VALUES (N'th206_1', N'Tin học 206.1')
INSERT INTO [dbo].[lop] ([malop], [tenlop]) VALUES (N'th207_1', N'Tin học 207.1')
INSERT INTO [dbo].[lop] ([malop], [tenlop]) VALUES (N'th208_1', N'Tin học 208 - Lớp 1')
INSERT INTO [dbo].[lop] ([malop], [tenlop]) VALUES (N'th208_2', N'Tin học 208 - Lớp 2')

INSERT INTO [dbo].[lylich] ([mshv], [tenhv], [ngaysinh], [phai], [malop]) VALUES (N'205001', N'Trần Khai Nguyên', N'1999-07-21 00:00:00', 1, N'th205_2')
INSERT INTO [dbo].[lylich] ([mshv], [tenhv], [ngaysinh], [phai], [malop]) VALUES (N'205002', N'Lý Văn Sang', N'2001-03-02 00:00:00', 1, N'th205_2')
INSERT INTO [dbo].[lylich] ([mshv], [tenhv], [ngaysinh], [phai], [malop]) VALUES (N'206002', N'Trần Bình Trọng', N'1998-05-12 00:00:00', 1, N'th206_1')
INSERT INTO [dbo].[lylich] ([mshv], [tenhv], [ngaysinh], [phai], [malop]) VALUES (N'206007', N'Phan Thị Lan', N'1993-12-13 00:00:00', 0, N'th206_1')
INSERT INTO [dbo].[lylich] ([mshv], [tenhv], [ngaysinh], [phai], [malop]) VALUES (N'207004', N'Lê Thị Nga', N'1995-08-10 00:00:00', 0, N'th207_1')
INSERT INTO [dbo].[lylich] ([mshv], [tenhv], [ngaysinh], [phai], [malop]) VALUES (N'208015', N'Lê Thị Hằng', N'2006-05-28 00:00:00', 0, N'th206_1')
INSERT INTO [dbo].[lylich] ([mshv], [tenhv], [ngaysinh], [phai], [malop]) VALUES (N'a', N'Văn An', N'2005-03-24 00:00:00', 1, N'th205_2')
INSERT INTO [dbo].[lylich] ([mshv], [tenhv], [ngaysinh], [phai], [malop]) VALUES (N'b', N'Kim Bình', N'2002-07-25 00:00:00', 1, N'th206_1')
INSERT INTO [dbo].[lylich] ([mshv], [tenhv], [ngaysinh], [phai], [malop]) VALUES (N'c', N'Trần Cầm', N'2003-02-14 00:00:00', 0, N'th208_1')
INSERT INTO [dbo].[lylich] ([mshv], [tenhv], [ngaysinh], [phai], [malop]) VALUES (N'x', N'Xung', N'1999-02-26 00:00:00', 1, N'th208_1')


INSERT INTO [dbo].[monhoc] ([msmh], [tenmh], [sotiet]) VALUES (N'aa', N'Hệ điều hành', 60)
INSERT INTO [dbo].[monhoc] ([msmh], [tenmh], [sotiet]) VALUES (N'c', N'Lập trình c', 45)
INSERT INTO [dbo].[monhoc] ([msmh], [tenmh], [sotiet]) VALUES (N'csdl', N'Nhập môn cơ sở dữ liệu', 45)
INSERT INTO [dbo].[monhoc] ([msmh], [tenmh], [sotiet]) VALUES (N'ctks', N'Công tác kỹ sư', 60)
INSERT INTO [dbo].[monhoc] ([msmh], [tenmh], [sotiet]) VALUES (N'hdh', N'Hệ điều hành', 60)
INSERT INTO [dbo].[monhoc] ([msmh], [tenmh], [sotiet]) VALUES (N'ktmt', N'Kiến trúc máy tính', 45)
INSERT INTO [dbo].[monhoc] ([msmh], [tenmh], [sotiet]) VALUES (N'ltw', N'Lập trình Windows', 30)
INSERT INTO [dbo].[monhoc] ([msmh], [tenmh], [sotiet]) VALUES (N'nmth', N'Nhập môn tin học', 45)


INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'205001', N'ctks', N'7')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'205001', N'hdh', N'2')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'205001', N'ktmt', N'')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'205001', N'ltw', N'6')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'205001', N'nmth', N'')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'205002', N'csdl', N'4')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'205002', N'ctks', N'5')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'205002', N'hdh', N'3')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'205002', N'ktmt', N'')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'205002', N'ltw', N'8')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'205002', N'nmth', N'6')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'206002', N'ctks', N'9')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'206002', N'hdh', N'4')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'206002', N'ltw', N'5')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'206002', N'nmth', N'4')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'206007', N'csdl', N'5')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'206007', N'ctks', N'6')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'206007', N'hdh', N'5')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'206007', N'ktmt', N'7')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'206007', N'ltw', N'4')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'206007', N'nmth', N'')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'207004', N'csdl', N'8')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'207004', N'ctks', N'')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'207004', N'hdh', N'6')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'207004', N'ktmt', N'')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'207004', N'ltw', N'7')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'207004', N'nmth', N'7')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'208015', N'csdl', N'9')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'208015', N'ltw', N'4')
INSERT INTO [dbo].[diemthi] ([mshv], [msmh], [diem]) VALUES (N'208015', N'nmth', N'9')
