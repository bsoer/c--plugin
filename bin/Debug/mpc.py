#import arcinfo
import arcpy
#import clr
#clr.AddReference("System.Windows.Forms")

arcpy.env.workspace = "C:/Users/bsoer/Desktop" 
arcpy.PackageMap_management('jan.mxd', 'EditingExercise1.mpk', "PRESERVE", "CONVERT_ARCSDE", "#", "ALL")

#from System.Windows.Forms import MessageBox
#MessageBox.Show("Hello World")