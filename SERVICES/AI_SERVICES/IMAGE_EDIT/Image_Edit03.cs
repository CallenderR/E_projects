using E_APP02.MODELS.AI_MODEL.AI_GET_MODEL;
using E_APP02.MODELS.AI_MODEL.AI_SET_MODEL;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using E_APP02.SERVICES.FILE_SERVICES.TEXT_FILES.READ_TEXTFIELS;


//https://rapidapi.com/MorfranTechnology/api/faceswap-image-transformation-api/playground/apiendpoint_5c88cb2a-9f54-4ad7-a6a3-f06e3f428517?env=undefined
namespace E_APP02.SERVICES.AI_SERVICES.IMAGE_EDIT
{
    internal class Image_Edit03
    {
        private  List<string> ResultImageUrl = new List<string>();
        private  List<int> FaceSwapCount = new List<int>();
        private  List<bool> Success = new List<bool>();
        private  List<string> Message = new List<string>();
        private  List<int> StatusCode = new List<int>();
        private  List<string> ProcessingTime = new List<string>();
        private  List<string> ProcessingTimeSpan = new List<string>();
        private  List<DateTime?> ProcessStartedDateTime = new List<DateTime?>();
        private  string[] data01 = new string[100];
        private  List<string> ResultUrl = new List<string>();
        private  List<string> image_list01 = new List<string>();
        private  List<int> High = new List<int>();
        private  List<int> Low = new List<int>();
        private  List<double> Confidence = new List<double>();
        private  List<bool> Value = new List<bool>();
        private  List<double> Height = new List<double>();
        private  List<double> Left = new List<double>();
        private  List<double> Top = new List<double>();
        private  List<double> Width = new List<double>();
        private  List<double> Confidence01 = new List<double>();
        private  List<double> Confidence02 = new List<double>();
        private  List<double> Pitch = new List<double>();
        private  List<double> Yaw = new List<double>();
        private  List<double> Confidence03 = new List<double>();
        private  List<string> Value01 = new List<string>();
        private  List<double> Confidence04 = new List<double>();
        private  List<bool> Value02 = new List<bool>();
        private  List<double> Confidence05 = new List<double>();
        private  List<double> Confidence06 = new List<double>();
        private  List<bool> Value03 = new List<bool>();
        private  List<double> Confidence07 = new List<double>();
        private  List<double> X = new List<double>();
        private  List<double> Y = new List<double>();
        private  List<double> Confidence08 = new List<double>();
        private  List<string> Value04 = new List<string>();
        private  List<double> Confidence09 = new List<double>();
        private  List<bool> Value05 = new List<bool>();
        private  List<double> Pitch01 = new List<double>();
        private  List<double> Roll = new List<double>();
        private  List<double> Yaw01 = new List<double>();
        private  List<double> Brightness = new List<double>();
        private  List<double> Sharpness = new List<double>();
        private  List<int> Statuscode = new List<int>();
        private  List<double> Confidence10 = new List<double>();
        private  List<bool> Value06 = new List<bool>();
        private  List<double> Confidence11 = new List<double>();
        private  List<string> Value07 = new List<string>();
        private  List<bool> Value08 = new List<bool>();
        private  List<bool> Value09 = new List<bool>();
        private  List<bool> Value10 = new List<bool>();
        private  List<bool> Value11 = new List<bool>();
        public List<Ai_Set_Model03> collectiondata03 = new List<Ai_Set_Model03>();
        public List<Ai_Set_Model05> collectiondata05 = new List<Ai_Set_Model05>();
        public List<Ai_Set_Model06> collectiondata06 = new List<Ai_Set_Model06>();
        private static Read_Textfiles01 READ = new Read_Textfiles01();

        public async Task<string> Face_Swap_Single_Face(string[] input01)
        {
            //input01= url photto
            string input02 = $"{{\"TargetImageUrl\":\"{input01[0].Trim()}\",\"SourceImageUrl\":\"{input01[1].Trim()}\"}}";
            data01[3] = await face_swap_data("https://faceswap-image-transformation-api.p.rapidapi.com/faceswap", input02);

             return data01[3];
        }


        public async Task<string> Face_Swap_Multiple_Faces(string[] input01)
        {
            //input01= url photto
            string input02 = $"{{\"TargetImageUrl\":\"{input01[0]}\",\"SourceImageUrl\":\"{input01[1]}\",\"MatchGender\":true,\"MaximumFaceSwapNumber\":5,\"FaceSizeThreshold\":0.05}}";
            data01[4] = await face_swap_data("https://faceswap-image-transformation-api.p.rapidapi.com/faceswapgroup", input02);
            return data01[4];
        }

        public async Task<string> Face_Swap_Single_Base64(string input01, string input02)
        {
            //input01= base64

            input02 = $"{{\"TargetImageBase64Data\":\"{input01}\"}}";
            data01[5] = await face_swap_data01("https://faceswap-image-transformation-api.p.rapidapi.com/faceswapbase64", input01, input02);
            return data01[5];
        }
        public async Task<string> Face_Swap_Multiple_Base64(string input01, string input02)
        {
            //input01= base64
            input02 = $"{{\"MatchGender\":true,\"MaximumFaceSwapNumber\":5,\"FaceSizeThreshold\":0.05,\"TargetImageBase64Data\":\"{input01}\"}}";

            data01[6] = await face_swap_data01("https://faceswap-image-transformation-api.p.rapidapi.com/faceswapgroupbase64", input01, input02);
            return data01[6];
        }

        public async Task<string> Face_Swap_One_To_All_Base64(string input01, string input02)
        {
            //input01= base64
            input02 = $"{{\"MatchGender\":true,\"MaximumFaceSwapNumber\":5,\"FaceSizeThreshold\":0.05,\"TargetImageBase64Data\":\"{input01}\"}}";

            data01[7] = await face_swap_data01("https://faceswap-image-transformation-api.p.rapidapi.com/faceswapgroupbase64onetoall", input01, input02);
            return data01[7];
        }

        public async Task<string> Face_Swap_One_To_All_Faces(string input01)
        {
            //input01= url
            string input02 = $"{{\"MatchGender\":true,\"MaximumFaceSwapNumber\":5,\"FaceSizeThreshold\":0.05,\"TargetImageBase64Data\":\"{input01}\"}}";

            data01[8] = await face_swap_data("https://faceswap-image-transformation-api.p.rapidapi.com/faceswapgrouponetoall?MatchGender=true&MaximumFaceSwapNumber=8", input02);
            return data01[8];
        }

        public async Task<string> Image_Temporary_Storage_API(string input01, string input02)
        {
            //input01= base64
            input02 = $"{{\"MatchGender\":true,\"MaximumFaceSwapNumber\":5,\"FaceSizeThreshold\":0.05,\"TargetImageBase64Data\":\"{input01}\"}}";

            data01[9] = await face_swap_data02("\"https://faceswap-image-transformation-api.p.rapidapi.com/face/store", input01, input02);
            return data01[9];
        }

        public async Task<string> Face_Swap_Multiple_Source_Urls_NEW(string input01, string input02, string[] input03)
        {
            //input01=url group photo
            //input03[]=url individual photo to change in group photo
            for (int i = 0; i < input03.Length; i++)
            {
                image_list01.Add($"\"{input03[i]}\"");
            }

            // Create JSON body correctly
            input02 =
                $"{{\"TargetImageUrl\":\"{input01}\"," +
                $"\"SourceImageUrls\":[{string.Join(",", image_list01)}]," +
                $"\"MatchGender\":true," +
                $"\"MaximumFaceSwapNumber\":5," +
                $"\"FaceSizeThreshold\":0.05}}";



            data01[10] = await face_swap_data("https://faceswap-image-transformation-api.p.rapidapi.com/faceswapgroupmultisource", input02);
            return data01[10];
        }



        public async Task<string> Face_Recognition_Facial_Analysis(string input01)
        {

            //input01=url photo


            data01[11] = await face_swap_data03("https://faceswap-image-transformation-api.p.rapidapi.com/faceswapgroupmultisource", input01);
            return data01[11];
        }



        public async Task<string> Face_Beautify_Enhancer(string input01)
        {

            //input01=url photo

            string input02 = $"{{\"ImageUrl\":\"{input01}\"}}";


            data01[12] = await face_swap_data("https://faceswap-image-transformation-api.p.rapidapi.com/faceswapgroupmultisource", input01);
            return data01[12];
        }


        private async Task<string> face_swap_data(string input01, string input02)
        {
            //input == image url
            //input == photo of urself url
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(input01),
                Headers =
    {
        { "x-rapidapi-key", READ.api[0].Trim() },
        { "x-rapidapi-host", "faceswap-image-transformation-api.p.rapidapi.com" },
    },
                Content = new StringContent(input02)

                {
                    Headers =
        {
            ContentType = new MediaTypeHeaderValue("application/json")
        }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Ai_Model05.Root resaults = JsonConvert.DeserializeObject<Ai_Model05.Root>(body);
                if (resaults != null)
                {
                    ResultImageUrl.Add(resaults.ResultImageUrl);
                    FaceSwapCount.Add(resaults.FaceSwapCount);
                    Success.Add(resaults.Success);
                    Message.Add(resaults.Message);
                    StatusCode.Add(resaults.StatusCode);
                    ProcessingTime.Add(resaults.ProcessingTime);
                    ProcessingTimeSpan.Add(resaults.ProcessingTimeSpan);
                    ProcessStartedDateTime.Add(resaults.ProcessStartedDateTime);


                }
                else
                {
                    ResultImageUrl.Add("");
                    FaceSwapCount.Add(0);
                    Success.Add(false);
                    Message.Add("");
                    StatusCode.Add(0);
                    ProcessingTime.Add("");
                    ProcessingTimeSpan.Add("");
                    ProcessStartedDateTime.Add(null);
                }
                var collection_set = new Ai_Set_Model03
                {
                    ResultImageUrl = ResultImageUrl.Count > 0 ? ResultImageUrl[0] : null,
                    FaceSwapCount = FaceSwapCount.Count > 0 ? FaceSwapCount[0] : 0,
                    Success = Success.Count > 0 ? Success[0] : false,
                    Message = Message.Count > 0 ? Message[0] : null,
                    StatusCode = StatusCode.Count > 0 ? StatusCode[0] : 0,
                    ProcessingTime = ProcessingTime.Count > 0 ? ProcessingTime[0] : null,
                    ProcessingTimeSpan = ProcessingTimeSpan.Count > 0 ? ProcessingTimeSpan[0] : null,
                    ProcessStartedDateTime = ProcessStartedDateTime.Count > 0 ? ProcessStartedDateTime[0] : null,
                };
                collectiondata03.Add(collection_set);
                data01[0] =

             $"{string.Join(" ", ResultImageUrl)}\n" +
                $"{string.Join(" ", FaceSwapCount)}\n" +
                $"{string.Join(" ", Success)}\n" +
                $"{string.Join(" ", Message)}\n" +
                $"{string.Join(" ", StatusCode)}\n" +
                $"{string.Join(" ", ProcessingTime)}\n" +
                $"{string.Join(" ", ProcessingTimeSpan)}\n" +
                $"{string.Join(" ", ProcessStartedDateTime)}\n";

           
            }
            data01[15] = ResultImageUrl[0];
            return data01[0];
        }
        private async Task<string> face_swap_data01(string input01, string input02, string input03)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(input01),
                Headers =
    {
        { "x-rapidapi-key",READ.api[0].Trim()  },
        { "x-rapidapi-host", "faceswap-image-transformation-api.p.rapidapi.com" },
    },
                Content = new StringContent(input03)

                {
                    Headers =
        {
            ContentType = new MediaTypeHeaderValue("application/json")
        }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Ai_Model06.Root resaults = JsonConvert.DeserializeObject<Ai_Model06.Root>(body);
                if (resaults != null)
                {
                    ResultImageUrl.Add(resaults.ResultImageUrl);
                    Success.Add(resaults.Success);
                    Message.Add(resaults.Message);
                    ProcessingTime.Add(resaults.ProcessingTime);
                    ProcessingTimeSpan.Add(resaults.ProcessingTimeSpan);


                }
                else
                {
                    ResultImageUrl.Add(" ");
                    Success.Add(false);
                    Message.Add(" ");
                    ProcessingTime.Add(" ");
                    ProcessingTimeSpan.Add(" ");
                }
                var collection_set = new Ai_Set_Model03
                {

                    ResultImageUrl = ResultImageUrl.Count > 0 ? ResultImageUrl[0] : null,
                    Success = Success.Count > 0 ? Success[0] : false,
                    Message = Message.Count > 0 ? Message[0] : null,
                    ProcessingTime = ProcessingTime.Count > 0 ? ProcessingTime[0] : null,
                    ProcessingTimeSpan = ProcessingTimeSpan.Count > 0 ? ProcessingTimeSpan[0] : null,
                };
                collectiondata03.Add(collection_set);
                data01[0] =
                  $"{string.Join(" ", ResultImageUrl)}\n" +
                  $"{string.Join(" ", ResultImageUrl)}\n" +
                  $"{string.Join(" ", Success)}\n" +
                  $"{string.Join(" ", Message)}\n" +
                  $"{string.Join(" ", ProcessingTime)}\n" +
                  $"{string.Join(" ", ProcessingTimeSpan)}\n";
            }
            return data01[0];
        }
        private async Task<string> face_swap_data02(string input01, string input02, string input03)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(input01),
                Headers =
    {
        { "x-rapidapi-key",READ.api[0].Trim()  },
        { "x-rapidapi-host", "faceswap-image-transformation-api.p.rapidapi.com" },
    },
                Content = new StringContent(input03)

                {
                    Headers =
        {
            ContentType = new MediaTypeHeaderValue("application/json")
        }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Ai_Model07.Root resaults = JsonConvert.DeserializeObject<Ai_Model07.Root>(body);
                if (resaults != null)
                {
                    ResultUrl.Add(resaults.Url);
                    Success.Add(resaults.Success);
                    Message.Add(resaults.Message);
                    StatusCode.Add(resaults.StatusCode);
                    ProcessingTime.Add(resaults.ProcessingTime);
                    ProcessingTimeSpan.Add(resaults.ProcessingTimeSpan);
                    ProcessStartedDateTime.Add(resaults.ProcessStartedDateTime);


                }
                else
                {
                    ResultUrl.Add("");
                    Success.Add(false);
                    Message.Add("");
                    StatusCode.Add(0);
                    ProcessingTime.Add(null);
                    ProcessingTimeSpan.Add(null);
                    ProcessStartedDateTime.Add(null);
                }
                var collection_set = new Ai_Set_Model05
                {


                    Url = ResultUrl.Count > 0 ? ResultUrl[0] : null,
                    Success = Success.Count > 0 ? Success[0] : false,
                    Message = Message.Count > 0 ? Message[0] : null,
                    StatusCode = StatusCode.Count > 0 ? StatusCode[0] : 0,
                    ProcessingTime = ProcessingTime.Count > 0 ? ProcessingTime[0] : null,
                    ProcessingTimeSpan = ProcessingTimeSpan.Count > 0 ? ProcessingTimeSpan[0] : null,
                    ProcessStartedDateTime = ProcessStartedDateTime.Count > 0 ? ProcessStartedDateTime[0] : null,
                };
                collectiondata05.Add(collection_set);
                data01[1] =

                   $"{string.Join(" ", ResultUrl)}\n" +
                   $"{string.Join(" ", Success)}\n" +
                   $"{string.Join(" ", Message)}\n" +
                   $"{string.Join(" ", StatusCode)}\n" +
                   $"{string.Join(" ", ProcessingTime)}\n" +
                   $"{string.Join(" ", ProcessingTimeSpan)}\n" +
                   $"{string.Join(" ", ProcessStartedDateTime)}\n";
            }
            return data01[1];
        }
        private async Task<string> face_swap_data03(string input01, string input02)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(input01),
                Headers =
    {
        { "x-rapidapi-key",READ.api[0].Trim()  },
        { "x-rapidapi-host", "faceswap-image-transformation-api.p.rapidapi.com" },
    },
                Content = new StringContent(input02)

                {
                    Headers =
        {
            ContentType = new MediaTypeHeaderValue("application/json")
        }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Ai_Model08.Root resaults = JsonConvert.DeserializeObject<Ai_Model08.Root>(body);
                if (resaults != null)
                {
                    Success.Add(resaults.Success);
                    Message.Add(resaults.Message);
                    Statuscode.Add(resaults.Statuscode);
                    ProcessingTime.Add(resaults.ProcessingTime);
                    ProcessingTimeSpan.Add(resaults.ProcessingTimeSpan);

                    if (resaults.FaceDetails != null)
                    {
                        foreach (var a in resaults.FaceDetails)
                        {
                            High.Add(a.AgeRange.High);
                            Low.Add(a.AgeRange.Low);
                            Confidence.Add(a.Beard.Confidence);
                            Value.Add(a.Beard.Value);

                            Height.Add(a.BoundingBox.Height);
                            Left.Add(a.BoundingBox.Left);
                            Top.Add(a.BoundingBox.Top);
                            Width.Add(a.BoundingBox.Width);
                            Confidence01.Add(a.Confidence);
                            if (a.Emotions != null)
                            {
                                foreach (var b in a.Emotions)
                                {
                                    Confidence02.Add(b.Confidence);
                                    Value01.Add(b.Type.Value);
                                }
                            }
                            else
                            {
                                Confidence02.Add(0);
                                Value01.Add(null);
                            }

                            Confidence02.Add(a.EyeDirection.Confidence);
                            Pitch.Add(a.EyeDirection.Confidence);
                            Yaw.Add(a.EyeDirection.Confidence);
                            Confidence03.Add(a.Eyeglasses.Confidence);
                            Value02.Add(a.Eyeglasses.Value);
                            Confidence04.Add(a.EyesOpen.Confidence);
                            Value03.Add(a.EyesOpen.Value);
                            Confidence05.Add(a.FaceOccluded.Confidence);
                            Value06.Add(a.FaceOccluded.Value);
                            Confidence06.Add(a.Gender.Confidence);

                            Value04.Add(a.Gender.Value.MyValue);
                            if (a.Landmarks != null)
                            {
                                foreach (var b in a.Landmarks)
                                {

                                    Value07.Add(b.Type.Value);
                                    X.Add(b.X);
                                    Y.Add(b.Y);
                                }
                            }
                            else
                            {

                                Value07.Add("");
                                X.Add(0);
                                Y.Add(0);
                            }

                            Value08.Add(a.MouthOpen.Value);
                            Confidence07.Add(a.MouthOpen.Confidence);
                            Value09.Add(a.Mustache.Value);
                            Confidence08.Add(a.Mustache.Confidence);
                            Pitch.Add(a.Pose.Pitch);
                            Roll.Add(a.Pose.Roll);
                            Yaw.Add(a.Pose.Yaw);
                            Brightness.Add(a.Quality.Brightness);
                            Sharpness.Add(a.Quality.Sharpness);
                            Value10.Add(a.Smile.Value);
                            Confidence09.Add(a.Smile.Confidence);
                            Value11.Add(a.Sunglasses.Value);
                            Confidence10.Add(a.Sunglasses.Confidence);
                        }

                    }
                    else
                    {
                        High.Add(0);
                        Low.Add(0);
                        Confidence.Add(0);
                        Value.Add(false);
                        Height.Add(0);
                        Left.Add(0);
                        Top.Add(0);
                        Width.Add(0);
                        Confidence01.Add(0);
                        Confidence02.Add(0);
                        Pitch.Add(0);
                        Yaw.Add(0);
                        Confidence03.Add(0);
                        Value02.Add(false);
                        Confidence04.Add(0);
                        Value03.Add(false);
                        Confidence05.Add(0);
                        Value06.Add(false);
                        Confidence06.Add(0);
                        Value04.Add("");
                        Value08.Add(false);
                        Confidence07.Add(0);
                        Value09.Add(false);
                        Confidence08.Add(0);
                        Pitch.Add(0);
                        Roll.Add(0);
                        Yaw.Add(0);
                        Brightness.Add(0);
                        Sharpness.Add(0);
                        Value10.Add(false);
                        Confidence09.Add(0);
                        Value11.Add(false);
                        Confidence10.Add(0);
                    }


                }
                else
                {
                    Success.Add(false);
                    Message.Add(null);
                    Statuscode.Add(0);
                    ProcessingTime.Add(null);
                    ProcessingTimeSpan.Add(null);
                }
                var collection_set = new Ai_Set_Model06
                {

                    Success = Success.Count > 0 ? Success[0] : false,
                    Message = Message.Count > 0 ? Message[0] : null,
                    Statuscode = Statuscode.Count > 0 ? Statuscode[0] : 0,
                    ProcessingTime = ProcessingTime.Count > 0 ? ProcessingTime[0] : null,
                    ProcessingTimeSpan = ProcessingTimeSpan.Count > 0 ? ProcessingTimeSpan[0] : null,
                    High = High.Count > 0 ? High[0] : 0,
                    Low = Low.Count > 0 ? Low[0] : 0,
                    Confidence = Confidence.Count > 0 ? Confidence[0] : 0,
                    Value = Value.Count > 0 ? Value[0] : false,
                    Height = Height.Count > 0 ? Height[0] : 0,
                    Left = Left.Count > 0 ? Left[0] : 0,
                    Top = Top.Count > 0 ? Top[0] : 0,
                    Width = Width.Count > 0 ? Width[0] : 0,
                    Confidence01 = Confidence01.Count > 0 ? Confidence01[0] : 0,
                    Confidence02 = Confidence02.Count > 0 ? Confidence02[0] : 0,
                    Value01 = Value01.Count > 0 ? Value01[0] : null,
                    Pitch = Pitch.Count > 0 ? Pitch[0] : 0,
                    Yaw = Yaw.Count > 0 ? Yaw[0] : 0,
                    Confidence03 = Confidence03.Count > 0 ? Confidence03[0] : 0,
                    Value02 = Value02.Count > 0 ? Value02[0] : false,
                    Confidence04 = Confidence04.Count > 0 ? Confidence04[0] : 0,
                    Value03 = Value03.Count > 0 ? Value03[0] : false,
                    Confidence05 = Confidence05.Count > 0 ? Confidence05[0] : 0,
                    Value06 = Value06.Count > 0 ? Value06[0] : false,
                    Confidence06 = Confidence06.Count > 0 ? Confidence06[0] : 0,
                    Value04 = Value04.Count > 0 ? Value04[0] : null,
                    Value07 = Value07.Count > 0 ? Value07[0] : null,
                    X = X.Count > 0 ? X[0] : 0,
                    Y = Y.Count > 0 ? Y[0] : 0,
                    Value08 = Value08.Count > 0 ? Value08[0] : false,
                    Confidence07 = Confidence07.Count > 0 ? Confidence07[0] : 0,
                    Value09 = Value09.Count > 0 ? Value09[0] : false,
                    Confidence08 = Confidence08.Count > 0 ? Confidence08[0] : 0,
                    Roll = Roll.Count > 0 ? Roll[0] : 0,
                    Brightness = Brightness.Count > 0 ? Brightness[0] : 0,
                    Sharpness = Sharpness.Count > 0 ? Sharpness[0] : 0,
                    Value10 = Value10.Count > 0 ? Value10[0] : false,
                    Confidence09 = Confidence09.Count > 0 ? Confidence09[0] : 0,
                    Value11 = Value11.Count > 0 ? Value11[0] : false,
                    Confidence10 = Confidence10.Count > 0 ? Confidence10[0] : 0,
                };

                collectiondata06.Add(collection_set);
                data01[2] =

                   $"{string.Join(" ", ResultUrl)}\n" +
           $"{string.Join(" ", Success)}\n" +
                      $"{string.Join(" ", Message)}\n" +
                      $"{string.Join(" ", Statuscode)}\n" +
                        $"{string.Join(" ", ProcessingTime)}\n" +
                       $"{string.Join(" ", ProcessingTimeSpan)}\n" +
                      $"{string.Join(" ", High)}\n" +
                        $"{string.Join(" ", Low)}\n" +
                       $"{string.Join(" ", Confidence)}\n" +
                     $"{string.Join(" ", Value)}\n" +
                     $"{string.Join(" ", Height)}\n" +
                      $"{string.Join(" ", Left)}\n" +
                    $"{string.Join(" ", Top)}\n" +
                     $"{string.Join(" ", Width)}\n" +
                      $"{string.Join(" ", Confidence01)}\n" +
                      $"{string.Join(" ", Confidence02)}\n" +
                      $"{string.Join(" ", Value01)}\n" +
                        $"{string.Join(" ", Confidence02)}\n" +
                        $"{string.Join(" ", Pitch)}\n" +
                    $"{string.Join(" ", Yaw)}\n" +
                       $"{string.Join(" ", Confidence03)}\n" +
                     $"{string.Join(" ", Value02)}\n" +
                        $"{string.Join(" ", Confidence04)}\n" +
                     $"{string.Join(" ", Value03)}\n" +
                      $"{string.Join(" ", Confidence05)}\n" +
                      $"{string.Join(" ", Value06)}\n" +
                         $"{string.Join(" ", Confidence06)}\n" +
                        $"{string.Join(" ", Value04)}\n" +
                        $"{string.Join(" ", Value07)}\n" +
                       $"{string.Join(" ", X)}\n" +
                        $"{string.Join(" ", Y)}\n" +
                       $"{string.Join(" ", Value08)}\n" +
                         $"{string.Join(" ", Confidence07)}\n" +
                       $"{string.Join(" ", Value09)}\n" +
                       $"{string.Join(" ", Confidence08)}\n" +
                       $"{string.Join(" ", Pitch)}\n" +
                         $"{string.Join(" ", Roll)}\n" +
                      $"{string.Join(" ", Yaw)}\n" +
                      $"{string.Join(" ", Brightness)}\n" +
                       $"{string.Join(" ", Sharpness)}\n" +
                       $"{string.Join(" ", Value10)}\n" +
                          $"{string.Join(" ", Confidence09)}\n" +
                         $"{string.Join(" ", Value11)}\n" +
                     $"{string.Join(" ", Confidence10)}\n";
                return data01[2];
            }
        }
    }
}