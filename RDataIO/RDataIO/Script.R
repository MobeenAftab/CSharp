library("farff")
library("RWeka")
library("RWekajars")
#search()

#options(java.parameters = "-Xmx2048m")
options(java.parameters = "-Xmx8000m")

library(rJava)

#installed.packages()

# Read soybean dataset from arff file
# data1 = read.csv(file.choose(), header = FALSE, sep = ",")
# data1
# Read edited soybean file, csv

# Write arff file
# write.arff(data1, file = "./soy.arff", eol = "\n")
# > soybean <- read.csv(file="C:/Users/Mobeen/AppData/Local/Temp/soybean.csv.utf8", header=FALSE, row.names=NULL, encoding="UTF-8", sep=",", dec=".", quote="\"", comment.char="")


fer2018 <- read.csv(file.choose(), header = FALSE, row.names = NULL, encoding = "UTF-8", sep = ",", dec = ".", quote = "\"", comment.char = "")
write.arff(fer2018, file = "fer2018.arff", eol = "\n")