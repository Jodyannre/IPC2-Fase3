-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE crearBodega
	-- Add the parameters for the stored procedure here
	@nombre varchar(50),
	@descripcion varchar(50),
	@direccion varchar(50),
	@resultado int output
AS
BEGIN TRY
	-- insertando en bodega
	INSERT INTO BODEGA
	(
		Nombre, 
		Descripcion, 
		Direccion_Codigo
	)
	VALUES(
		@nombre,
		@descripcion,
		@direccion	
	);
	set @resultado =  0;
	RETURN @resultado;
END TRY
BEGIN CATCH
	SELECT @resultado = ERROR_NUMBER();
	print @@ERROR +'-Descripcion del error: '+ ERROR_MESSAGE();
	RETURN @resultado;
END CATCH
GO
