// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.Iot.Hub.Service.Models;

namespace Azure.Iot.Hub.Service
{
    /// <summary> The Job service client. </summary>
    internal partial class JobClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal JobRestClient RestClient { get; }
        /// <summary> Initializes a new instance of JobClient for mocking. </summary>
        protected JobClient()
        {
        }
        /// <summary> Initializes a new instance of JobClient. </summary>
        internal JobClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "https://fully-qualified-iothubname.azure-devices.net", string apiVersion = "2020-03-13")
        {
            RestClient = new JobRestClient(clientDiagnostics, pipeline, host, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Create a new import or export job on IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. </summary>
        /// <param name="jobProperties"> Specifies the job specification. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobProperties>> CreateImportExportJobAsync(JobProperties jobProperties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobClient.CreateImportExportJob");
            scope.Start();
            try
            {
                return await RestClient.CreateImportExportJobAsync(jobProperties, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a new import or export job on IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. </summary>
        /// <param name="jobProperties"> Specifies the job specification. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobProperties> CreateImportExportJob(JobProperties jobProperties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobClient.CreateImportExportJob");
            scope.Start();
            try
            {
                return RestClient.CreateImportExportJob(jobProperties, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the status of all import and export jobs in IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<JobProperties>>> GetImportExportJobsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobClient.GetImportExportJobs");
            scope.Start();
            try
            {
                return await RestClient.GetImportExportJobsAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the status of all import and export jobs in IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<JobProperties>> GetImportExportJobs(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobClient.GetImportExportJobs");
            scope.Start();
            try
            {
                return RestClient.GetImportExportJobs(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the status of an import or export job in IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobProperties>> GetImportExportJobAsync(string id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobClient.GetImportExportJob");
            scope.Start();
            try
            {
                return await RestClient.GetImportExportJobAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the status of an import or export job in IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobProperties> GetImportExportJob(string id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobClient.GetImportExportJob");
            scope.Start();
            try
            {
                return RestClient.GetImportExportJob(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancels an import or export job in IoT Hub. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> CancelImportExportJobAsync(string id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobClient.CancelImportExportJob");
            scope.Start();
            try
            {
                return await RestClient.CancelImportExportJobAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancels an import or export job in IoT Hub. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> CancelImportExportJob(string id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobClient.CancelImportExportJob");
            scope.Start();
            try
            {
                return RestClient.CancelImportExportJob(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves details of a scheduled job from IoT hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobResponse>> GetJobAsync(string id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobClient.GetJob");
            scope.Start();
            try
            {
                return await RestClient.GetJobAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves details of a scheduled job from IoT hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobResponse> GetJob(string id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobClient.GetJob");
            scope.Start();
            try
            {
                return RestClient.GetJob(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new job to schedule twin updates or direct methods on IoT Hub at a scheduled time. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="jobRequest"> The job to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobResponse>> CreateJobAsync(string id, JobRequest jobRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobClient.CreateJob");
            scope.Start();
            try
            {
                return await RestClient.CreateJobAsync(id, jobRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new job to schedule twin updates or direct methods on IoT Hub at a scheduled time. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="jobRequest"> The job to be created. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobResponse> CreateJob(string id, JobRequest jobRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobClient.CreateJob");
            scope.Start();
            try
            {
                return RestClient.CreateJob(id, jobRequest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancels a scheduled job on IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobResponse>> CancelJobAsync(string id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobClient.CancelJob");
            scope.Start();
            try
            {
                return await RestClient.CancelJobAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancels a scheduled job on IoT Hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. </summary>
        /// <param name="id"> The unique identifier of the job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobResponse> CancelJob(string id, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobClient.CancelJob");
            scope.Start();
            try
            {
                return RestClient.CancelJob(id, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query IoT hub to retrieve information regarding jobs using the IoT Hub query language. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language for more information. </summary>
        /// <param name="jobType"> The job type. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs#querying-for-progress-on-jobs for a list of possible job types. </param>
        /// <param name="jobStatus"> The job status. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs#querying-for-progress-on-jobs for a list of possible statuses. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<QueryResult>> QueryJobsAsync(string jobType = null, string jobStatus = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobClient.QueryJobs");
            scope.Start();
            try
            {
                return await RestClient.QueryJobsAsync(jobType, jobStatus, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query IoT hub to retrieve information regarding jobs using the IoT Hub query language. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language for more information. </summary>
        /// <param name="jobType"> The job type. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs#querying-for-progress-on-jobs for a list of possible job types. </param>
        /// <param name="jobStatus"> The job status. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs#querying-for-progress-on-jobs for a list of possible statuses. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<QueryResult> QueryJobs(string jobType = null, string jobStatus = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JobClient.QueryJobs");
            scope.Start();
            try
            {
                return RestClient.QueryJobs(jobType, jobStatus, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
