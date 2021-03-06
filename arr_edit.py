# this script will write a single subject js arrays (for both questions and answers)
# **the images folders should contain same amount of files at the same names!**
# (otherwise some answers will not show up.) - for examples- look at the given files.
import os

# full path to one of the images folder # leave the 'r' where it is.
dir_path = r""
file_path = r""  # full path to .js file to edit
subject = "Algorithms"  # subject name with underscores if needed
directory = os.fsencode(dir_path)
arr_name = subject + '=[\n'

start_str = '"'
end_str = '",\n'
imagesarr = ''


def write_to_js(array_name, imagesList):
    str_to_write = array_name + imagesList + ']'
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

write_to_js(arr_name, imagesarr)
