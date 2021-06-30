  var arr = [];
  var random;
  var count = 0;
  var doneQuestions;
  var questionsArr;
  var subject;

  /*
   *TODO: 
   * add css/bootstrap
   * 
   */

  function init() {
      localStorage.clear();
      arrays = {
          "Algorithms": Algorithms_arr,
          "Computational_models": Computational_models_arr,
          "Data_communication_networks": Data_communication_networks_arr
      }
      $('#btngetQuestion').hide();
      createDDL();
  }

  function createDDL() {
      keys = Object.keys(arrays);
      let str = ' <option value="-1">please select a subject</option>';
      for (let i = 0; i < keys.length; i++) {
          str += ' <option value="' + keys[i] + '">' + keys[i] + '</option>';
      }
      $('#subjectDDL').html(str);
  }

  function selectsubject() {
      subject = $("#subjectDDL").val();

      if (subject == "-1")
          $('#btngetQuestion').hide();
      //if (subject != "-1") {
      else {
          $('#btngetQuestion').show();
          questionsArr = arrays[subject];
      }
  }

  function GetIndex(len) {
      return Math.floor(Math.random() * len);
  }

  function getQuestion() {
      str = "";
      $('#ph2').html("");
      $('#btnGetAnswer').css("visibility", "visible");
      random;
      if (arr.length == questionsArr.length - 1) {
          arr = [];
          count = 0;
      }

      do {
          flag = true;
          random = GetIndex(questionsArr.length - 1);
          for (var i = 0; i < arr.length; i++) {
              if (random == arr[i])
                  flag = false;
          }
      } while (flag == false);

      str = "<img src='/Exams_prep/images/" + subject + "/questions/" + questionsArr[random] + "'>"; //server
      //str = "<img src='/images/" + subject + "/questions/" + questionsArr[random] + "'>"; //local
      $('#ph').html(str);
      arr.push(random);
      count++;
      $('#ph3').html(count + "/" + questionsArr.length);
  }

  function getAnswer() {
      //remove file extention for type -> assignment
      let parts = questionsArr[random].split(".");
      let filename = parts[0];
      let type = "Assignment";

      //remove file extension and practice mark ('t')
      if (filename.includes('t') || filename.includes('e')) {
          if (filename.includes('t'))
              type = "practice";
          else
              type = "exam";
          parts = questionsArr[random].split("."); //remove file extention
          parts = parts[0].split(type);
          filename = parts[1];
      }

      str = "<p>" + type + " ==>" + filename + "<== Question </p>";

      str += "<img src='/Exams_prep/images/" + subject + "/answers/" + questionsArr[random] + "'>"; //server
      // str += "<img src='/images/" + subject + "/answers/" + questionsArr[random] + "'>"; //local

      $('#ph2').html(str);
      $('#btnGetAnswer').css("visibility", "hidden");
  }

  //Events
  window.onbeforeunload = function() {
      localStorage.clear();
  };