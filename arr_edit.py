#this script will write a single subject js arrays (for both questions and answers
#the images folders should contain same amount of files at the same names! 
#(otherwise some answers will not show up.) - for examples- look at the given files.
import os

dir_path = r"" #full path to one of the images folder # leave the 'r' where it is.
file_path = r"" #full path to .js file to edit # leave the 'r' where it is.
subject = "Algorithms"   #"<subject name WITH UNDERSCORES!>"
directory = os.fsencode(dir_path)
arr1_name = subject+ '_Questions=[\n'
arr2_name = subject+ '_Answers=[\n'
start_str = '"'
end_str = '",\n'
imagesarr = ''


def write_to_js(array1_name,array2_name, imagesList):
    str_to_write = array1_name + imagesList + '],\n'
    str_to_write += array2_name + imagesList + ']'
    f = open(file_path, 'w')
    f.write(str_to_write)
    f.close
    
file_list = os.listdir(directory)
for file in file_list:
    filename = os.fsdecode(file)
    if filename.endswith(".jpg") or filename.endswith(".jpeg") or filename.endswith(".png") or filename.endswith(".webp"):
        if file == file_list[len(file_list)-1]:
            end_str = '"\n'
        imagesarr += start_str + filename + end_str
        continue
    else:
        continue

write_to_js(arr1_name,arr2_name, imagesarr)