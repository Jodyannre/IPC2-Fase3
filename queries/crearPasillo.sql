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
CREATE PROCEDURE crearPasillo
	-- Add the parameters for the stored procedure here
	@No_pasillo INT,
	@Largo FLOAT,
	@Ancho FLOAT,
	@Bodega INT,
	@Resultado INT OUTPUT
AS
BEGIN TRY
	--insertar en pasillo
	INSERT INTO PASILLO
	(
		No_pasillo,
		Largo, 
		Ancho
	)
	VALUES
	(
		@No_pasillo,
		@Largo,
		@Ancho
	);
	--insertar en detalle-bodega
	INSERT INTO DETALLE_BODEGA
	(
		PASILLO_No_pasillo,
		BODEGA_Codigo
	)
	VALUES
	(
		@No_pasillo,
		@Bodega
	);
	SET @resultado = 0;
	RETURN @resultado;
END TRY
BEGIN CATCH
	SELECT @resultado = ERROR_NUMBER();
	print @@ERROR +'-Descripcion del error: '+ ERROR_MESSAGE();
	RETURN @resultado;
END CATCH
